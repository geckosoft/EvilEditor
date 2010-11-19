using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EvilPlug.Filetypes.Lay;

namespace EvilPlug.Editors.MapEditor
{
    public partial class frmTileDetail : Form
    {
        public frmTileDetail()
        {
            InitializeComponent();
        }
        public frmTileDetail(LayMapTile tile)
        {
            InitializeComponent();

            ProcessTile(tile);
        }

        private void ProcessTile(LayMapTile tile)
        {
            Text += tile.Position.X.ToString() + "," + tile.Position.Y.ToString();
            txtTileId.Text = tile.Id + " (Raw id: " + tile.RawId + ")";
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
