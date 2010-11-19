using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EvilPlug.Filetypes.Lay;
using Extensions;

namespace EvilPlug.Editors.SaveGameEditor
{
    public partial class EvilRegionControl : UserControl
    {
        public EvilRegionControl()
        {
            InitializeComponent();
        }
        protected LayEntity m_Entity = null;
        public LayEntity Entity
        {
            get
            {
                return m_Entity;
            }
            set
            {
                m_Entity = value;
                ProcessEntity(value);
            }
        }

        public string RegionName
        {
            get
            {
                if (m_Entity == null)
                    return "";

                if (m_Entity.EntityDescriptionID == "1550")
                    return "P.A.T.R.I.O.T.";
                if (m_Entity.EntityDescriptionID == "1551")
                    return "S.A.B.R.E.";
                if (m_Entity.EntityDescriptionID == "1552")
                    return "H.A.M.M.E.R.";
                if (m_Entity.EntityDescriptionID == "1553")
                    return "A.N.V.I.L.";
                if (m_Entity.EntityDescriptionID == "1554")
                    return "S.M.A.S.H.";

                return "";
            }
        }

        public int Notoriety
        {
            get
            {
                if (m_Entity == null)
                    return 0;

                return m_Entity.GetProperty("NotorietyLevel").Value.ToInteger();
            }
        }

        private void ProcessEntity(LayEntity value)
        {
            txtHeat.Text = m_Entity.GetProperty("HeatLevel").Value;
            txtNotoriety.Text = m_Entity.GetProperty("NotorietyLevel").Value;
            txtTouristNumber.Text = m_Entity.GetProperty("DesiredTouristPopulation").Value;

            if (m_Entity.GetProperty("SuperAgentLocked").Value == "true")
                chkAUnlocked.Checked = false;
            else
                chkAUnlocked.Checked = true;

            if (m_Entity.GetProperty("SuperAgentDefeated").Value == "true")
                chkADefeated.Checked = true;
            else
                chkADefeated.Checked = false;

            groupBox1.Text = RegionName;
        }

        private void txtNotoriety_TextChanged(object sender, EventArgs e)
        {
            string tag = (string)((Control)sender).Tag;
            string text = ((Control)sender).Text;

            switch (tag)
            {
                case "Heat":
                    if ((!text.IsInteger()) && (text != ""))
                        text = m_Entity.GetProperty("HeatLevel").Value;

                    if (text == "")
                        break;
                    if (text.ToInteger() > 100)
                        text = "100";

                    m_Entity.GetProperty("HeatLevel").Value = text;
                    break;
                case "Notoriety":
                    if ((!text.IsInteger()) && (text != ""))
                        text = m_Entity.GetProperty("NotorietyLevel").Value;

                    if (text == "")
                        break;
                    if (text.ToInteger() > 100)
                        text = "100";

                    m_Entity.GetProperty("NotorietyLevel").Value = text;
                    break;
                case "Tourist":
                    if ((!text.IsInteger()) && (text != ""))
                        text = m_Entity.GetProperty("DesiredTouristPopulation").Value;

                    if (text == "")
                        break;

                    m_Entity.GetProperty("DesiredTouristPopulation").Value = text;
                    break;

            }

            ((Control)sender).Text = text;
        }

        private void chkAUnlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAUnlocked.Checked)
                m_Entity.GetProperty("SuperAgentLocked").Value = "false";
            else
                m_Entity.GetProperty("SuperAgentLocked").Value = "true";
        }

        private void chkADefeated_CheckedChanged(object sender, EventArgs e)
        {
            if (chkADefeated.Checked)
                m_Entity.GetProperty("SuperAgentDefeated").Value = "true";
            else
                m_Entity.GetProperty("SuperAgentDefeated").Value = "false";
        }
    }
}
