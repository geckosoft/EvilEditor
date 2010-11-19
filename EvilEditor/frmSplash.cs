using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvilEditor
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            lblStatus.Text = "Raising child henchmen...";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            lblStatus.Text = "Decorating the evil lair...";
            Application.DoEvents();

            Hide();
            new EvilGUI().ShowDialog();
            Close();
        }
    }
}
