using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Extensions;
using EvilPlug.Filetypes.Lay;
using EvilBase;

namespace EvilPlug.Editors.SaveGameEditor
{
    public partial class EvilGameEditor : Form
    {
        public EvilGameEditor()
        {
            InitializeComponent();
        }

        protected Thread m_Thread = null;
        protected bool m_Loading = true;
        protected bool m_Loaded = false;

        private void EvilGameEditor_Shown(object sender, EventArgs e)
        {
            m_Thread = new Thread(new ThreadStart(LoadLay));
            m_Thread.Start();
            FileInfo fi = new FileInfo(SaveGamePlugin.OpenFileDialog.FileName);

            lblStatus.Text = "Status: Loading " + fi.Name + " ...";
        }
        private void LoadLay()
        {
            m_Loading = true;
            m_Loaded = false;
            try
            {
                SaveGamePlugin.LayFile = new EvilPlug.Filetypes.Lay.LayFile(SaveGamePlugin.OpenFileDialog.FileName);
            }
            catch
            {
                m_Loading = false;
                return;
            }
            lock (this)
            {
                m_Loading = false;
                m_Loaded = true;
            }
        }
        

        private void tmrLoadProgress_Tick(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(SaveGamePlugin.OpenFileDialog.FileName);
            if (SaveGamePlugin.LayFile == null)
                return;
            lblStatus.Text = "Status: Loading " + fi.Name + " ... (" + SaveGamePlugin.LayFile.Properties.Count + " lines processed)";

            if ((m_Loaded))
            {
                lblStatus.Text = "Status: Saved game loaded. Processed " + SaveGamePlugin.LayFile.Properties.Count + " lines.";
                LoadFields(SaveGamePlugin.LayFile);
                tabEditor.Visible = true;
                tmrLoadProgress.Enabled = false;

            }
            else if ((!m_Loaded) && (!m_Loading))
            {
                lblStatus.Text = "Error loading saved game.";
                tmrLoadProgress.Enabled = false;
                tabEditor.Enabled = false;
            }
        }

        protected string m_GeniusEntityID = "";
        protected LayEntity m_EvilGenius = null;
        List<EvilRegionControl> m_Regions = new List<EvilRegionControl>();


        private void LoadFields(EvilPlug.Filetypes.Lay.LayFile layObject)
        {
            try
            {
                txtMoney.Text = layObject.FindProperty("Cash").Value;
                if (layObject.FindProperty("GeniusEntityID") == null)
                    throw new Exception("Invalid savegame.");

                m_GeniusEntityID = layObject.FindProperty("GeniusEntityID").Value;

                cmbAlertState.SelectedIndex = int.Parse(layObject.FindProperty("AlertStatus").Value);
                cmbDifficulty.SelectedIndex = int.Parse(layObject.FindProperty("DifficultyLevel").Value);

                // Find the evil genius entry
                m_EvilGenius = layObject.FindEntityById(m_GeniusEntityID);

                txtEGHealth.Text = m_EvilGenius.Stats.Health;
                txtEGName.Text = m_EvilGenius.Name;
                txtEGID.Text = m_EvilGenius.EntityDescriptionID;
                txtEGLoyalty.Text = m_EvilGenius.Stats.Loyalty;
                txtEGSmarts.Text = m_EvilGenius.Stats.Smarts;
                txtEGAttention.Text = m_EvilGenius.Stats.Attention;
                txtEGEndurance.Text = m_EvilGenius.Stats.Endurance;

                // Load the minion recruitment fields
                for (int c = 0; c < grpRec.Controls.Count; c++)
                {
                    Control ctrl = grpRec.Controls[c];

                    if (ctrl.GetType() == typeof(TextBox))
                    {
                        string minID = (string)((TextBox)ctrl).Tag;

                        // Load minion stuff
                        List<LayProperty> props = SaveGamePlugin.LayFile.FindProperties("DesiredMinionCount");

                        for (int i = 0; i < props.Count; i++)
                        {
                            LayProperty prop = props[i];

                            try
                            {
                                if (prop.Value.Substring(0, 4) == minID + ",")
                                {
                                    ((TextBox)ctrl).Text = prop.Value.Substring(prop.Value.IndexOf(",") + 1);
                                    break;
                                }
                            }
                            catch { }
                        }

                    }
                }

                txtRecCost.Text = layObject.FindProperty("MinionRecruitmentCost").Value;
                txtRecRate.Text = layObject.FindProperty("MinionRecruitmentRate").Value;
                txtRecTime.Text = layObject.FindProperty("SecondsSinceLastAutoSpawned").Value;

                txtBasePower.Text = layObject.FindProperty("BasePowerSupply").Value;

                #region Load henchmen tab
                string[] henchmenIds = new string[] { "500", "501", "502", "503", "504", "505", "507", "508", "509", "510", "511" };
                string[] henchNames = new string[] { "Moko the big strong dumb one.", "Jubei the Samurai swordsman and sushi master.", "Eli the hard-hitting, fast-talking gangster.", "Red Ivan, always ready for action.", "Montezuma, the dark and sinister voodoo man.", "The Matron - isn't it past your bedtime?", "Lord Kane, the arch-conspirator himself.", "That looks nasty, would you like me to take a closer look?", "Look into my eye, you are feeling sleepy...", "The charming Dr Neurocide, insane or genius ahead of her time?", "Colonel Blackheart, he has your trail." };

                bool found = false;
                int locModifier = 0;

                GroupBox baseBox = null;

                for (int c = 0; c < tabHenchman.Controls.Count; c++)
                {
                    Control ctrl = tabHenchman.Controls[c];

                    if (ctrl.GetType() != typeof(GroupBox))
                        continue;

                    baseBox = (GroupBox)ctrl;
                    break;
                }
                int ix = 0;

                // evilHench1
                int cntx = -1;
                foreach (string hID in henchmenIds)
                {
                    LayEntity hench = SaveGamePlugin.LayFile.FindEntity(hID);
                    cntx++;
                    if (hench == null)
                    {
                        continue;
                    }
                    string henchName = henchNames[cntx];
                    EvilHenchControl ectrl = new EvilHenchControl();
                    tabHenchman.SuspendLayout();
                    tabHenchman.Controls.Add(ectrl);
                    ectrl.Tag = hID;
                    ectrl.Left = 0;
                    ectrl.Top = 0 + (ectrl.Height * ix);
                    ectrl.BringToFront();
                    ectrl.Text = henchName;
                    tabHenchman.ResumeLayout();
                    tabHenchman.PerformLayout();
                    tabHenchman.Refresh();
                    ix++;
                }

                foreach (string hID in henchmenIds)
                {
                    // See if we have the henchman
                    LayEntity hench = SaveGamePlugin.LayFile.FindEntity(hID);
                    if (hench == null)
                        found = false;
                    else
                        found = true;


                    for (int c = 0; c < tabHenchman.Controls.Count; c++)
                    {
                        Control ctrl = tabHenchman.Controls[c];

                        if (ctrl.GetType() != typeof(EvilHenchControl))
                            continue;

                        EvilHenchControl evilHench = (EvilHenchControl)ctrl;

                        GroupBox hBox = evilHench.groupBox2;

                        if ((string)evilHench.Tag == hID)
                        {
                            evilHench.Entity = hench;
                        }
                    }
                }
                #endregion


                #region Load regions tab
                string[] regionIds = new string[] { "1550", "1551", "1552", "1553", "1554" }; // TODO order alphabetical

                cntx = -1;
                ix = 0;
                int regHeight = lblTotalNotoriety.Height;

                foreach (string rID in regionIds)
                {
                    LayEntity region = SaveGamePlugin.LayFile.FindEntity(rID);
                    cntx++;
                    if (region == null)
                    {
                        continue;
                    }
                    EvilRegionControl ectrl = new EvilRegionControl();
                    tabRegions.SuspendLayout();
                    tabRegions.Controls.Add(ectrl);
                    ectrl.Tag = rID;
                    ectrl.Left = 0;
                    ectrl.Top = regHeight + (ectrl.Height * ix);
                    ectrl.BringToFront();
                    tabRegions.ResumeLayout();
                    tabRegions.PerformLayout();
                    tabRegions.Refresh();
                    m_Regions.Add(ectrl);
                    ix++;
                }

                foreach (string rID in regionIds)
                {
                    // See if we have the henchman
                    LayEntity region = SaveGamePlugin.LayFile.FindEntity(rID);
                    if (region == null)
                        found = false;
                    else
                        found = true;


                    for (int c = 0; c < tabRegions.Controls.Count; c++)
                    {
                        Control ctrl = tabRegions.Controls[c];

                        if (ctrl.GetType() != typeof(EvilRegionControl))
                            continue;

                        EvilRegionControl evilRegion = (EvilRegionControl)ctrl;


                        if ((string)evilRegion.Tag == rID)
                        {
                            evilRegion.Entity = region;
                        }
                    }
                }
                #endregion

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error loading saved game: " + ex.Message;
                tmrLoadProgress.Enabled = false;
                tabEditor.Enabled = false;
            }
        }

        private void EvilGameEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Dispose();
            }
            catch { }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            SaveGamePlugin.LayFile.FindProperty("Cash").Value = (((int)(txtMoney.Text.ToInteger() / 500)) * 500).ToString(); 

            LayEntity lt = SaveGamePlugin.LayFile.FindEntity("13007");

            if (lt == null)
                return;

            lt.GetProperty("NumGoldBars").Value = ((int)(txtMoney.Text.ToInteger() / 500)).ToString();

            List<LayEntity> allGoldBars = SaveGamePlugin.LayFile.FindEntities("13007");

            for (int i = 0; i < allGoldBars.Count; i++)
            {
                if (allGoldBars[i] == lt)
                    continue;

                allGoldBars[i].Delete();
            }
        }

        private void cmbAlertState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveGamePlugin.LayFile.FindProperty("AlertStatus").Value = cmbAlertState.SelectedIndex.ToString();
        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveGamePlugin.LayFile.FindProperty("DifficultyLevel").Value = cmbDifficulty.SelectedIndex.ToString();
        }

        private bool ValidateDouble(object sender)
        {
            bool added = false;
            TextBox txt = (TextBox)sender;
            string text = txt.Text;
            text = text.Replace(".", ",");
            if ((text == "") || (text == ","))
                return false;
            if (text.Substring(text.Length - 1, 1) == ",")
            {
                text += "0";
                added = true;
            }
            if ((text.CountOccurances(",") > 1) || (text.Substring(0, 1) == ","))
                return false;

            try
            {
                Double.Parse(text);
                txt.Text = text;
                if (added)
                {
                    Application.DoEvents();
                    txt.SelectionStart = txt.Text.IndexOf(",") + 1;
                    txt.SelectionLength = 1;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void txtEGHealth_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateDouble(sender))
            {
                ((TextBox)sender).Text = m_EvilGenius.Stats.Health;
                return;
            }

            m_EvilGenius.Stats.Health = txtEGHealth.Text.Replace(",", ".");
        }


        private void txtEGLoyalty_TextChanged(object sender, EventArgs e)
        {

            if (!ValidateDouble(sender))
            {
                ((TextBox)sender).Text = m_EvilGenius.Stats.Loyalty;
                return;
            }

            m_EvilGenius.Stats.Loyalty = ((TextBox)sender).Text.Replace(",", ".");
        }


        private void txtEGSmarts_TextChanged(object sender, EventArgs e)
        {

            if (!ValidateDouble(sender))
            {
                ((TextBox)sender).Text = m_EvilGenius.Stats.Smarts;
                return;
            }

            m_EvilGenius.Stats.Smarts = ((TextBox)sender).Text.Replace(",", ".");

        }


        private void txtEGAttention_TextChanged(object sender, EventArgs e)
        {

            if (!ValidateDouble(sender))
            {
                ((TextBox)sender).Text = m_EvilGenius.Stats.Attention;
                return;
            }

            m_EvilGenius.Stats.Attention = ((TextBox)sender).Text.Replace(",", ".");

        }


        private void txtEGEndurance_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateDouble(sender))
            {
                ((TextBox)sender).Text = m_EvilGenius.Stats.Endurance;
                return;
            }

            m_EvilGenius.Stats.Endurance = ((TextBox)sender).Text.Replace(",", ".");

        }


        private void txtEGName_TextChanged(object sender, EventArgs e)
        {
            if (txtEGName.Text == "")
            {
                txtEGName.Text = "Evil Genius";
                txtEGName.SelectAll();
            }
            m_EvilGenius.Name = txtEGName.Text;

        }
        internal E_SaveGameEditor SaveGamePlugin = null;

        private void btnFixStuckFleeing_Click(object sender, EventArgs evar)
        {
            DialogResult res = MessageBox.Show("Do you want to try fix stuck minions? If so, make sure you do not save to the same map file OR have made a backup!", "Confirm fix", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel)
                return;

            int fixedMinions = 0;
            LayFile lay = SaveGamePlugin.LayFile;

            List<LayEntity> entities = new List<LayEntity>();
            for (int i = 100; i < 113; i++)
            {
                entities = lay.FindEntities(i.ToString());

                for (int e = 0; e < entities.Count; e++)
                {
                    LayEntity minion = entities[e];

                    if (minion.Stats.Health.ToInteger() < 1)
                    {
                        if ((minion.GetProperty("IsDead") != null) || (minion.GetProperty("IsUnconscious") != null) || (minion.GetProperty("IsIncapacitated") != null))
                            continue;

                        minion.GetProperty("EarmarkedForEntityID").Value = "0";
                        minion.GetProperty("ForceDesert").Value = "false";

                        if (minion.GetProperty("InteractionObject") != null)
                            minion.GetProperty("InteractionObject").Deleted = true;
                        if (minion.GetProperty("InteractionSlotIndex") != null)
                            minion.GetProperty("InteractionSlotIndex").Deleted = true;
                        if (minion.GetProperty("InteractionTermReq") != null)
                            minion.GetProperty("InteractionTermReq").Deleted = true;

                        fixedMinions++;
                    }
                }
            }

            MessageBox.Show("Fixed " + fixedMinions.ToString() + " minion(s). Be sure to test out if the fix worked!", "Fix applied.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btlCleanDeadMinions_Click(object sender, EventArgs ex)
        {
            DialogResult res = MessageBox.Show("Do you want to try clean hidden dead minions? If so, make sure you do not save to the same map file OR have made a backup!", "Confirm fix", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel)
                return;

            int fixedMinions = 0;
            LayFile lay = SaveGamePlugin.LayFile;

            List<LayEntity> entities = new List<LayEntity>();
            for (int i = 100; i < 113; i++)
            {
                entities = lay.FindEntities(i.ToString());

                for (int e = 0; e < entities.Count; e++)
                {
                    LayEntity minion = entities[e];

                    if (minion.Stats.Health.ToInteger() < 1)
                    {
                        if ((minion.GetProperty("IsDead") != null) && (minion.GetProperty("IsUnconscious") != null) && (minion.GetProperty("IsIncapacitated") != null) && (minion.GetProperty("Destroyed") != null) && (minion.GetProperty("NotInGame") == null))
                        {
                            int cnt = 0;
                            List<LayProperty> props = lay.FindProperties("EntityID");
                            foreach (LayProperty prop in props)
                            {
                                if (prop.Value == minion.EntityID)
                                {
                                    cnt++;
                                }
                            }
                            if (cnt == 1)
                            {
                                minion.Delete();
                                fixedMinions++;
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Cleaned " + fixedMinions.ToString() + " dead hidden minion(s). Be sure to test out if the fix worked!", "Fix applied.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnToolsHider_Click(object sender, EventArgs e)
        {
            btnToolsHider.Visible = false;
        }

        private void txtRecCost_TextChanged(object sender, EventArgs e)
        {
            SaveGamePlugin.LayFile.FindProperty("MinionRecruitmentCost").Value = txtRecCost.Text.ToInteger().ToString();
        }

        private void desiredMinions_TextChanged(object sender, EventArgs e)
        {
            string minId = (string)((TextBox)sender).Tag;

            List<LayProperty> props = SaveGamePlugin.LayFile.FindProperties("DesiredMinionCount");

            for (int i = 0; i < props.Count; i++)
            {
                LayProperty prop = props[i];

                try
                {
                    if (prop.Value.Substring(0, 4) == minId + ",")
                    {
                        prop.Value = minId + "," + ((TextBox)sender).Text.ToInteger();
                        break;
                    }
                }
                catch { }
            }
        }

        private void txtRecRate_TextChanged(object sender, EventArgs e)
        {
            SaveGamePlugin.LayFile.FindProperty("MinionRecruitmentRate").Value = txtRecRate.Text.ToInteger().ToString();
        }

        private void txtRecTime_TextChanged(object sender, EventArgs e)
        {
            if (txtRecTime.Text.IsEvilDouble())
                SaveGamePlugin.LayFile.FindProperty("SecondsSinceLastAutoSpawned").Value = txtRecTime.Text.Replace(",", ".");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabHenchman_Scroll(object sender, ScrollEventArgs e)
        {
            tabHenchman.Refresh();

        }

        private void tmrNotoriety_Tick(object sender, EventArgs e)
        {
            string pref = "Global notoriety (sum of all regions): ";

            int total = 0;

            foreach (EvilRegionControl region in m_Regions)
            {
                total += region.Notoriety;
            }

            lblTotalNotoriety.Text = pref + total.ToString();
        }

        private void txtBasePower_TextChanged(object sender, EventArgs e)
        {
            string text = txtBasePower.Text;
            if ((!text.IsInteger()) && (text != ""))
            {
                txtBasePower.Text = SaveGamePlugin.LayFile.FindProperty("BasePowerSupply").Value;
                return;
            }

            if (text == "")
                return;

            SaveGamePlugin.LayFile.FindProperty("BasePowerSupply").Value = text;
        }

        private void EvilGameEditor_Load(object sender, EventArgs e)
        {
            btnToolsHider.BringToFront();
        }

        private void btnUnbuildableBitsReplacer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to try replace rocky parts with buildable parts found within the mountain? If so, make sure you do not save to the same map file OR have already made a backup!", "Confirm fix", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel)
                return;

            bool foundMap = false;
            for (int i = 0; i < SaveGamePlugin.LayFile.Properties.Count; i++)
            {
                LayProperty prop = SaveGamePlugin.LayFile.Properties[i];

                if (prop.Key == "GridDimensions")
                {
                    foundMap = true;
                    continue;
                }

                if (!foundMap)
                    continue;

                if (prop.Key == "DynamicATNData")
                {
                    break;
                }

                string mapPart = prop.Key;
                mapPart = mapPart.Replace("20006A", "20000A");
                prop.Key = mapPart;


            }

            MessageBox.Show("Rock bits replaced!", "Fix applied.", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



    }
}
