using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EvilBase;

namespace EvilEditor
{
    public partial class EvilGUI : Form
    {
        private int childFormNumber = 0;
        protected string m_Extension = "";
        public EvilGUI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openDialog.FileName;
                FileInfo fi = new FileInfo(FileName);

                evilEditors.OnFileOpen(FileName);
                evilEditors.DisableAllEditors();

                List<IPlugEditor> editors = evilEditors.FindEditorsByExt(fi.Extension.ToLower());
                m_Extension = fi.Extension;

                foreach (IPlugEditor editor in editors)
                {
                    editor.OpenFileDialog = openDialog;
                    editor.SaveFileDialog = saveDialog;
                    editor.Enabled = true;
                }

                editorsToolStripMenuItem.Font = new Font(editorsToolStripMenuItem.Font, FontStyle.Bold);
                tmrBoldEditors.Enabled = true;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveDialog.FileName;
                FileInfo fi = new FileInfo(FileName);

                List<IPlugEditor> editors = evilEditors.EditorPlugs;

                foreach (IPlugEditor editor in evilEditors.EditorPlugs)
                {
                    if ((editor.Enabled) && (editor.Opened))
                    {
                        editor.SaveFile(FileName);
                        openDialog.FileName = FileName;
                    }
                }
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            evilEditors.UnloadAllEditors();
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void EvilGUI_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolsMenu.DropDownItems.Add("Hello World");
        }

        private void tmrBoldEditors_Tick(object sender, EventArgs e)
        {
          //  editorsToolStripMenuItem.Font = new Font(editorsToolStripMenuItem.Font, FontStyle.Regular);
            tmrBoldEditors.Enabled = false;
        }

        private void editorsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            editorsToolStripMenuItem.Font = new Font(editorsToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (saveDialog.ShowDialog(this) == DialogResult.OK)
            //{
                string FileName = openDialog.FileName;
                FileInfo fi = new FileInfo(FileName);

                List<IPlugEditor> editors = evilEditors.EditorPlugs;

                foreach (IPlugEditor editor in evilEditors.EditorPlugs)
                {
                    if ((editor.Enabled) && (editor.Opened))
                    {
                        editor.SaveFile(FileName);
                    }
                }
           // }

        }

        private void EvilGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            evilEditors.UnloadAllEditors();
        }
    }
}
