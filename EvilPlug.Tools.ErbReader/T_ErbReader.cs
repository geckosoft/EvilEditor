using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EvilBase;

namespace EvilPlug.Tools.ErbReader
{
    public class T_ErbReader : IPlugTool
    {
        protected ToolStripItem m_MenuItem = null;
        protected Form m_Parent = null;
        #region IPlugTool Members

        public void Unload()
        {
            m_MenuItem.Visible = false;
            m_MenuItem.Dispose();
            m_MenuItem = null;

        }

        public void Load(Form parentForm, ToolStripMenuItem toolsMenu)
        {
            m_Parent = parentForm;
            m_MenuItem = toolsMenu.DropDownItems.Add("Extract Erb...");
            m_MenuItem.Click += new EventHandler(m_MenuItem_Click);
        }

        void m_MenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmExtract();
            frm.MdiParent = m_Parent;
            frm.Show();
        }

        #endregion

        #region IPlugBase Members

        public string Author
        {
            get { return "SinnerG"; }
        }

        public string Homepage
        {
            get { return ""; }
        }

        public string Description
        {
            get { return "Extract erb files"; }
        }

        public string LongDescription
        {
            get { return "Uses ErbReader.exe to extract the contents from the Evil Genius .erb files."; }
        }

        public string Name
        {
            get { return "ErbReader"; }
        }

        #endregion
    }
}
