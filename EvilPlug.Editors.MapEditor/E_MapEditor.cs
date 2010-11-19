using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilBase;
using EvilPlug.Filetypes.Lay;
using System.Windows.Forms;

namespace EvilPlug.Editors.MapEditor
{
    public class E_MapEditor : IPlugEditor
    {
        protected ToolStripItem m_MenuItem = null;
        protected Form m_Parent = null;
        protected frmMapEditor m_Editor = null;
        internal LayFile LayFile = null;

        #region IPlugEditor Members

        public void Unload()
        {
            m_MenuItem.Visible = false;
            m_MenuItem.Dispose();
            m_MenuItem = null;
            if ((m_Editor != null) && (!m_Editor.Disposing))
            {
                try
                {
                    m_Editor.Close();
                    m_Editor.Dispose();
                }
                catch
                {
                }
                m_Editor = null;
            }
        }

        public void FileOpened(string filename)
        {
            if ((m_Editor != null) && (!m_Editor.Disposing))
            {
                try
                {
                    m_Editor.Close();
                    m_Editor.Dispose();
                }
                catch
                {
                }
                m_Editor = null;
            }
        }

        public void Load(Form parentForm, ToolStripMenuItem editorMenu)
        {
            m_Parent = parentForm;
            m_MenuItem = editorMenu.DropDownItems.Add("Edit map...");
            m_MenuItem.Click += new EventHandler(m_MenuItem_Click);
            m_MenuItem.Tag = this; // Required !
        }

        void m_MenuItem_Click(object sender, EventArgs e)
        {
            if (!Enabled)
                return;

            if (Opened)
                return; // Can only have one open / time

            m_Editor = new frmMapEditor();
            m_Editor.Plugin = this;
            m_Editor.MdiParent = m_Parent;
            m_Editor.FormClosed += new FormClosedEventHandler(m_Editor_FormClosed);
            m_Editor.Show();
        }

        void m_Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_Editor = null;
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
            get { return "Edit maps"; }
        }

        public string LongDescription
        {
            get { return "Use this editor to modify maps."; }
        }

        public string Name
        {
            get { return "Map editor"; }
        }

        #endregion

        #region IPlugEditor Members

        public IPlugFileType[] HandledFileTypes
        {
            get
            {
                return (new IPlugFileType[] { new EvilPlug.Filetypes.Lay.FT_Lay() });
            }
        }

        public bool Opened
        {
            get
            {
                return ((m_Editor != null) && (!m_Editor.Disposing));
            }
        }

        public bool Enabled
        {
            get
            {
                if (m_MenuItem == null)
                    return false;

                return m_MenuItem.Enabled;
            }

            set
            {
                if (m_MenuItem == null)
                    return;
                m_MenuItem.Enabled = value;
            }
        }

        public bool ExclusiveMode { get { return true; } }

        public void SaveFile(string filename)
        {
            try
            {
                LayFile.Save(filename);
                m_Editor.lblStatus.Text = "Status: File saved.";
            }
            catch
            {
                m_Editor.lblStatus.Text = "Status: Error saving file.";
            }
        }
        protected OpenFileDialog m_OpenFile = null;
        public OpenFileDialog OpenFileDialog
        {
            get
            {
                return m_OpenFile;
            }
            set
            {
                m_OpenFile = value;
            }
        }

        protected SaveFileDialog m_SaveFile = null;
        public SaveFileDialog SaveFileDialog
        {
            get
            {
                return m_SaveFile;
            }
            set
            {
                m_SaveFile = value;
            }
        }
        #endregion
    }
}
