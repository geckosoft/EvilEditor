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
    public partial class EvilHenchControl : UserControl
    {
        public EvilHenchControl()
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

        private void ProcessEntity(LayEntity value)
        {
            LayEntity hench = m_Entity;
            GroupBox hBox = groupBox2;

            for (int c2 = 0; c2 < hBox.Controls.Count; c2++)
            {
                Control ctrl2 = hBox.Controls[c2];

                string ctrlTag = (string)ctrl2.Tag;

                switch (ctrlTag)
                {
                    case "Name":
                        ((TextBox)ctrl2).Text = hench.Name;
                        break;
                    case "Health":
                        ((TextBox)ctrl2).Text = hench.Stats.Health;
                        break;
                    case "Smarts":
                        ((TextBox)ctrl2).Text = hench.Stats.Smarts;
                        break;
                    case "Loyalty":
                        ((TextBox)ctrl2).Text = hench.Stats.Loyalty;
                        break;
                    case "Endurance":
                        ((TextBox)ctrl2).Text = hench.Stats.Endurance;
                        break;
                    case "Attention":
                        ((TextBox)ctrl2).Text = hench.Stats.Attention;
                        break;
                    case "Lives":
                        try
                        {
                            ((ComboBox)ctrl2).SelectedIndex = hench.Stats.Lives.ToInteger();
                        }
                        catch { }
                        break;

                    case "Abilities": // groupbox
                        for (int c3 = 0; c3 < ((GroupBox)ctrl2).Controls.Count; c3++)
                        {
                            Control ctrl3 = ((GroupBox)ctrl2).Controls[c3];

                            int index = 0;

                            switch ((string)ctrl3.Tag)
                            {
                                case "Skill1":
                                    ComboBox cbS1 = (ComboBox)ctrl3;
                                    foreach (string skill in cbS1.Items)
                                    {
                                        if (skill == hench.GetProperty("SpecialAbility", 1).Value)
                                        {
                                            cbS1.SelectedIndex = index;
                                            break;
                                        }
                                        index++;
                                    }
                                    break;
                                case "Skill2":
                                    ComboBox cbS2 = (ComboBox)ctrl3;
                                    foreach (string skill in cbS2.Items)
                                    {
                                        if (skill == hench.GetProperty("SpecialAbility", 2).Value)
                                        {
                                            cbS2.SelectedIndex = index;
                                            break;
                                        }
                                        index++;
                                    }
                                    break;
                                case "Skill1Learned":
                                    CheckBox cb1 = (CheckBox)ctrl3;

                                    if (hench.GetProperty("TrainingComplete", 1).Value == "true")
                                        cb1.Checked = true;
                                    else
                                        cb1.Checked = false;
                                    break;
                                case "Skill2Learned":
                                    CheckBox cb2 = (CheckBox)ctrl3;

                                    if (hench.GetProperty("TrainingComplete", 2).Value == "true")
                                        cb2.Checked = true;
                                    else
                                        cb2.Checked = false;
                                    break;
                            }
                        }
                        break;
                }
            }
        }


        public string Text
        {
            get
            {
                return groupBox2.Text;
            }
            set
            {
                groupBox2.Text = value;
            }
        }

        private void EvilHenchControl_Load(object sender, EventArgs e)
        {

        }

        private void stats_TextChanged(object sender, EventArgs e)
        {
            string tag = (string)((Control)sender).Tag;
            string text = ((Control)sender).Text;

            switch (tag)
            {
                case "Name":
                    if (text == "")
                        text = "Evil Genius";

                    m_Entity.Name = text;
                    break;

                case "Health":
                    if ((!text.IsEvilDouble()) && (text != ""))
                        text = m_Entity.Stats.Health;

                    if (text == "")
                        break;

                    m_Entity.Stats.Health = text;
                    break;
                case "Smarts":
                    if ((!text.IsEvilDouble()) && (text != ""))
                        text = m_Entity.Stats.Smarts;

                    if (text == "")
                        break;

                    m_Entity.Stats.Smarts = text;
                    break;
                case "Attention":
                    if ((!text.IsEvilDouble()) && (text != ""))
                        text = m_Entity.Stats.Attention;

                    if (text == "")
                        break;

                    m_Entity.Stats.Attention = text;
                    break;
                case "Endurance":
                    if ((!text.IsEvilDouble()) && (text != ""))
                        text = m_Entity.Stats.Endurance;

                    if (text == "")
                        break;

                    m_Entity.Stats.Endurance = text;
                    break;
                case "Loyalty":
                    if ((!text.IsEvilDouble()) && (text != ""))
                        text = m_Entity.Stats.Loyalty;

                    if (text == "")
                        break;

                    m_Entity.Stats.Loyalty = text;
                    break;
                    
            }

            ((Control)sender).Text = text;

        }

        private void comboFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tag = (string)((ComboBox)sender).Tag;
            int selectedItem = ((ComboBox)sender).SelectedIndex;
            string text = ((ComboBox)sender).SelectedItem.ToString();

            switch (tag)
            {
                case "Lives":
                    m_Entity.Stats.Lives = text;
                    break;

                case "Skill1":
                    m_Entity.GetProperty("SpecialAbility", 1).Value = text;
                    break;

                case "Skill2":
                    m_Entity.GetProperty("SpecialAbility", 2).Value = text;
                    break;

            }

           // ((Control)sender).Text = text;
        }
        protected override void WndProc(ref Message messg)
        {
            // turn the erase background message into a null message
            if ((int)0x0014 == messg.Msg) //if message is is erase background
            {
                messg.Msg = (int)0x0000; //reset message to null
            }
            base.WndProc(ref messg);
        }

        private void checkBoxesFields_CheckedChanged(object sender, EventArgs e)
        {
            string tag = (string)((CheckBox)sender).Tag;
            bool selected = ((CheckBox)sender).Checked;

            string text = "false";
            if (selected)
                text = "true";
            //int selectedItem = ((ComboBox)sender).SelectedIndex;
            //string text = ((ComboBox)sender).SelectedItem.ToString();

            switch (tag)
            {
                case "Skill1Learned":
                    m_Entity.GetProperty("TrainingComplete", 1).Value = text;
                    break;

                case "Skill2Learned":
                    m_Entity.GetProperty("TrainingComplete", 2).Value = text;
                    break;

            }

            //((Control)sender).Text = text;
        }
    }
}
