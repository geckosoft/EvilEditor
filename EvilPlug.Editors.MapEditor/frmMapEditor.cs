using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Tao.OpenGl;
using EvilPlug.Editors.MapEditor.OpenGl;
using EvilBase;
using EvilPlug.Filetypes.Lay;

namespace EvilPlug.Editors.MapEditor
{
    public partial class frmMapEditor : Form
    {
		#region Fields (16) 

        protected int m_FPS = 0;
        protected int m_FPS_Counter = 0;
        protected LayMapTile m_LastHoveredTile = null;
        protected MouseEventArgs m_LastMouseMovement = null;
        protected bool m_Loaded = false;
        protected bool m_Loading = true;
        protected LayMap m_Map = null;
        protected bool m_MouseHovering = false;
        protected int m_PositionX = 0;
        protected int m_PositionY = 0;
        protected Thread m_Thread = null;
        protected int m_Zoom = 2;
        protected LayMapTool MapTools = null;
        internal E_MapEditor Plugin = null;
        protected Stopwatch stopWatch = new Stopwatch();
        internal OGLTextureManager Textures = new OGLTextureManager();

		#endregion Fields 

		#region Constructors (1) 

        public frmMapEditor()
        {
            InitializeComponent();

            MouseWheel += new MouseEventHandler(frmMapEditor_MouseWheel);
        }

		#endregion Constructors 

		#region Methods (28) 

		// Private Methods (28) 

        private void CalculateFPS()
        {
            if (!stopWatch.IsRunning)
            {
                stopWatch.Start();
                m_FPS_Counter = 0;
                return;
            }
            m_FPS_Counter += 1;
            if (stopWatch.ElapsedMilliseconds > 1000)
            {
                m_FPS = (int)(m_FPS_Counter / (stopWatch.ElapsedMilliseconds / 1000));
                m_FPS_Counter = 0;
                stopWatch.Reset();
            }
            this.Text = "FPS: " + m_FPS.ToString();
        }

        private void drawSoimethingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMapEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            oGL.DestroyContexts();
        }

        void frmMapEditor_MouseWheel(object sender, MouseEventArgs e)
        {
            bool up = (e.Delta > 0);
            int oldZoom = m_Zoom;

            if (!up)
            {
                if (m_Zoom > 0)
                    m_Zoom--;
            }
            else
                m_Zoom++;

            if ((oldZoom != m_Zoom) && (m_LastHoveredTile != null))
            {
               // int midX = oGL.Width / 2;
                // int midY = oGL.Height / 2;
                int cX = (oGL.Width) / 2;
                int cY = (oGL.Height) / 2;
                cX += BoxSize / 2;
                cY += BoxSize / 2; 
              /*  int cX2 = (oGL.Width+m_PositionX) / BoxSize;
                int cY2 = (oGL.Height + m_PositionY) / BoxSize;
                int midX = cX * BoxSize;
                int midY = cY * BoxSize;
                */
                int lX = m_LastHoveredTile.Position.X *BoxSize;
                int lY = m_LastHoveredTile.Position.Y * BoxSize;
                //int lX2 = lX * BoxSize;
                //int lY2 = lY * BoxSize;
                //lX -= BoxSize / 2;
                //lY -= BoxSize / 2;
                m_PositionX = lX;
                m_PositionY = lY;
                m_PositionX -= (oGL.Width / 2);
                m_PositionY -= (oGL.Height / 2);
                Cursor cur = new Cursor(Cursor.Current.Handle);
               // cur.Pos
                
                Cursor.Position = oGL.PointToScreen(new Point(cX, cY));

            }
        }

        private void frmMapEditor_Shown(object sender, EventArgs e)
        {
            m_Thread = new Thread(new ThreadStart(LoadLay));
            m_Thread.Start();
            FileInfo fi = new FileInfo(Plugin.OpenFileDialog.FileName);

            lblStatus.Text = "Status: Loading " + fi.Name + " ...";
        }

        private int GetPosition(int xRy)
        {
            return (xRy / BoxSize) * BoxSize;
        }

        private int GetPositionOnMap(int xRy)
        {
            return (xRy / BoxSize);
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_LastHoveredTile == null)
                return;
            frmTileDetail tile = new frmTileDetail(m_LastHoveredTile);
            tile.ShowDialog();
        }

        private void LoadData(EvilPlug.Filetypes.Lay.LayFile layFile)
        {
            try
            {
                m_Map = new LayMap(layFile);
            }
            catch
            {
                lblStatus.Text = "Status: Error loading map data!";
                m_Loaded = false;
                m_Loading = false;
                return;
            }
            for (int y = 0; y < m_Map.Size.Height; y++)
            {

                for (int x = 0; x < m_Map.Size.Width; x++)
                {
                    LayMapTile tile = m_Map.Tiles[x, y];
                    tile.Tag = new ExtraTileInfo(tile, Textures);
                }
            }
            WindowState = FormWindowState.Normal;
            Application.DoEvents();
            WindowState = FormWindowState.Maximized;
            m_Loaded = true;
            m_Loading = false;

            MapTools = new LayMapTool(Plugin.LayFile, m_Map);
        }

        private void LoadLay()
        {
            m_Loading = true;
            m_Loaded = false;
            try
            {
                Plugin.LayFile = new EvilPlug.Filetypes.Lay.LayFile(Plugin.OpenFileDialog.FileName);
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

        private void mnuTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuTools_Opening(object sender, CancelEventArgs e)
        {
            lblTileMenuEntry.Text = m_LastHoveredTile.Id + " (" + m_LastHoveredTile.Position.X.ToString() + "," + m_LastHoveredTile.Position.Y.ToString() + ")";
            mnuObjects.Visible = chkViewObjects.Checked;
            if (chkViewObjects.Checked)
            {
                mnuObjects.DropDownItems.Clear();
                //Application.DoEvents();
                // Load objects
                List<LayEntity> objects = Plugin.LayFile.GetObjectEntities(m_LastHoveredTile.Position.X , m_LastHoveredTile.Position.Y);

                foreach (LayEntity obj in objects)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)mnuObjects.DropDownItems.Add(obj.EntityDescriptionID + " (ID: " + obj.EntityID + ")");
                    item.CheckState = CheckState.Indeterminate;
                    item.Tag = obj;
                    if (obj.Deleted)
                    {
                        ToolStripMenuItem pendingDeletion = (ToolStripMenuItem)item.DropDownItems.Add("Pending Removal (Click to Undo)");
                        pendingDeletion.ToolTipText = "Click to undo delete";
                        pendingDeletion.Click += new EventHandler(pendingDeletion_Click);
                    }
                    else
                    {
                        ToolStripMenuItem deleteItem = (ToolStripMenuItem)item.DropDownItems.Add("Remove");
                        deleteItem.Click += new EventHandler(frmMapEditor_Click);
                    }
                }
            }
        }

        void pendingDeletion_Click(object sender, EventArgs e)
        {
            LayEntity obj = (LayEntity)((ToolStripMenuItem)sender).OwnerItem.Tag;

            obj.UndoDelete();
        }

        void frmMapEditor_Click(object sender, EventArgs e)
        {
            LayEntity obj = (LayEntity)((ToolStripMenuItem)sender).OwnerItem.Tag;

            obj.Delete();
        }

        private void oGL_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("lol");
        }

        private void oGL_Click_1(object sender, EventArgs e)
        {
            LayMapTile tile = m_LastHoveredTile;

            if (tile == null)
                return;

            LayEntity parent = Plugin.LayFile.FindEntityByGridLocation(tile.Position.X, tile.Position.Y);

            if (parent == null)
                return;
            if (parent.TilesGrid.Tiles.Count > 0)
            {
                MapTools.UnselectAllTiles();
                MapTools.SelectGrid(parent.TilesGrid);
            }
        }

        private void oGL_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void oGL_MouseEnter(object sender, EventArgs e)
        {
            m_MouseHovering = true;
        }

        private void oGL_MouseHover(object sender, EventArgs e)
        {
            m_MouseHovering = true;
        }

        private void oGL_MouseLeave(object sender, EventArgs e)
        {
            m_MouseHovering = false;
        }

        private void oGL_MouseMove(object sender, MouseEventArgs e)
        {
            m_LastMouseMovement = e;

            if (m_Map == null)
                return;

            int x = GetPositionOnMap(e.X + m_PositionX);
            if (x < 0)
                return;

            int y = GetPositionOnMap(e.Y + m_PositionY);
            if (y < 0)
                return;

            if ((x < m_Map.Size.Width) && (y < m_Map.Size.Height))
                m_LastHoveredTile = m_Map.Tiles[x, y];
        }

        private void oGL_Paint(object sender, PaintEventArgs e)
        {
            Gl.glViewport(0, 0, oGL.Width, oGL.Height);
            // Clear the background
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_STENCIL_BUFFER_BIT);

            Gl.glClearColor(Color.OrangeRed.R / 255, Color.OrangeRed.G / 255, Color.OrangeRed.B / 255, 1.0f);
            Gl.glLoadIdentity(); // Reset the view

            if (chkViewMap.Checked)
                RenderMap();

            if (chkViewPattern.Checked)
                RenderDebugPattern();
            if (chkViewObjects.Checked)
                RenderObjects();



            if (MapTools != null)
                RenderSelectedTilesBoxes();

            if ((m_LastMouseMovement != null) && (m_LastMouseMovement.X >= 0) && (m_LastMouseMovement.Y >= 0))
            {
                RenderMouseMovement();
            }

            CalculateFPS();


        }

        private void RenderObjects()
        {
            List<LayEntity> objects = Plugin.LayFile.GetObjectEntities();

            foreach (LayEntity obj in objects)
            {

                
                RenderObject(obj);
                
                if (obj.Deleted)
                {
                    OGLTools.DrawLine(Color.Red, new Position2D(obj.Pattern.Location.X * BoxSize + BoxSize - m_PositionX, obj.Pattern.Location.Y * BoxSize + BoxSize - m_PositionY), new Dimension2D(BoxSize, BoxSize));
                    OGLTools.DrawLine(Color.Red, new Position2D(obj.Pattern.Location.X * BoxSize + BoxSize + BoxSize - m_PositionX, obj.Pattern.Location.Y * BoxSize + BoxSize - m_PositionY), new Dimension2D(BoxSize * -1, BoxSize));
                }
            }
        }

        private void RenderObject(LayEntity obj)
        {
            OGLTexture text = Textures.LoadTexture(EvilTools.GetExecutingPath(@"MapEditor\Objects\" + obj.EntityDescriptionID + ".png"));

            if (text == null)
            {
                OGLTools.DrawFilledRectangle(Color.Green, new Position2D(obj.Pattern.Location.X * BoxSize + BoxSize - m_PositionX, obj.Pattern.Location.Y * BoxSize + BoxSize - m_PositionY), new Dimension2D(BoxSize, BoxSize));
                return;
            }

            OGLTools.DrawTexture(text, new Position2D(0, 0), text.Size, new Position2D(obj.Pattern.Location.X * BoxSize + BoxSize - m_PositionX, obj.Pattern.Location.Y * BoxSize + BoxSize - m_PositionY), new Dimension2D(BoxSize, BoxSize), 1f);
        }

        private void RenderDebugPattern()
        {
            LayEntity ent = Plugin.LayFile.FindEntity("13029");

            if (ent == null)
                return;

            // draw the console!
            OGLTexture text = Textures.LoadTexture(EvilTools.GetExecutingPath(@"MapEditor\Objects\13029.png"));

            //OGLTools.DrawTexture(text, new Position2D(0, 0), text.Size, new Position2D(ent.Pattern.Location.X * BoxSize - m_PositionX, ent.Pattern.Location.Y * BoxSize - m_PositionY), text.Size, 1.0f);
            OGLTools.DrawTexture(text, new Position2D(0, 0), text.Size, new Position2D(GetPosition(ent.Pattern.Location.X * BoxSize) - m_PositionX + BoxSize, GetPosition(ent.Pattern.Location.Y * BoxSize) - m_PositionY + BoxSize), new Position2D(ent.Pattern.Location.X * BoxSize - m_PositionX + BoxSize * 5, ent.Pattern.Location.Y * BoxSize - m_PositionY + BoxSize + BoxSize), 1.0f);
 
            OGLTools.DrawRectangle(Color.Red, new Position2D(ent.Pattern.Location.X * BoxSize + BoxSize - m_PositionX, ent.Pattern.Location.Y * BoxSize + BoxSize - m_PositionY), new Dimension2D(BoxSize, BoxSize));
        }

        private int BoxSize
        {
            get
            {
                return 8 * (int)Math.Pow(2, m_Zoom);
            }
        }
        private void RenderSelectedTilesBoxes()
        {
            List<LayMapTile> tiles = MapTools.GetSelectedTiles();
            int boxSize = BoxSize;

            foreach (LayMapTile tile in tiles)
            {
                int bX, bY = 0;

                bX = tile.Position.X * boxSize;// -m_PositionX;
                bY = tile.Position.Y * boxSize;// -m_PositionY; 

                //bX = GetPosition(bX + m_PositionX) - m_PositionX;
                //bY = GetPosition(bY + m_PositionY) - m_PositionY;

                if ((bX < m_PositionX - 32) || (bY < m_PositionY - 32))
                    continue;

                // TODO improve rendering
                OGLTools.DrawRectangle(Color.White, new Position2D(  bX - m_PositionX, bY - m_PositionY), new Dimension2D(boxSize, boxSize));

            }

        }

        private void oGL_Resize(object sender, EventArgs e)
        {

        }

        private void oGL_Resize_1(object sender, EventArgs e)
        {
            Gl.glViewport(0, 0, oGL.Width, oGL.Height);
            OGLTools.glDisable2D();
            OGLTools.RestoreOrtho();
        }

 // (2 * 4) * 8 = 64 // other possible: 1 (32)
        private void RenderMap()
        {
            if (m_Map == null)
                return;

            //OGLTexture txt = Textures.LoadTexture(EvilTools.GetExecutingPath(@"MapEditor\Tiles\22029.png"));

            int yStart = 0;
            int xStart = 0;

            xStart = GetPositionOnMap( m_PositionX);
            yStart =  GetPositionOnMap(m_PositionY);

            for (int y = yStart; y < m_Map.Size.Height; y++)
            {
                if ((y * BoxSize) > oGL.Height + m_PositionY)
                    continue;

                for (int x = xStart; x < m_Map.Size.Width; x++)
                {
                    if ((x * BoxSize) > oGL.Width + m_PositionX)
                        continue;

                    LayMapTile tile = m_Map.Tiles[x, y];
                    ExtraTileInfo info = (ExtraTileInfo)tile.Tag;

                    OGLTools.DrawTexture(info.Texture, new Position2D(0, 0), new Dimension2D(info.Texture.Size.Width, info.Texture.Size.Height), new Position2D((x * BoxSize) - m_PositionX, (y * BoxSize) - m_PositionY), new Dimension2D(BoxSize, BoxSize), 1f);
                }
            }
        }

        private void RenderMouseMovement()
        {
            int x = GetPosition(m_LastMouseMovement.X + m_PositionX) - m_PositionX;
            int y = GetPosition(m_LastMouseMovement.Y + m_PositionY) - m_PositionY;
            OGLTools.DrawRectangle(Color.White, new Position2D(x, y), new Dimension2D(BoxSize, BoxSize));
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            oGL.InitializeContexts();
            OGLTools.oGL = oGL;
        }

        private void tmrLoadProcess_Tick(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(Plugin.OpenFileDialog.FileName);
            if (Plugin.LayFile == null)
                return;
            lblStatus.Text = "Status: Loading " + fi.Name + " ... (" + Plugin.LayFile.Properties.Count + " lines processed)";

            if ((m_Loaded))
            {
                tmrLoadProcess.Enabled = false;
                lblStatus.Text = "Status: Lay file loaded. Processed " + Plugin.LayFile.Properties.Count + " lines.";
                LoadData(Plugin.LayFile);

            }
            else if ((!m_Loaded) && (!m_Loading))
            {
                lblStatus.Text = "Error loading lay file.";
                tmrLoadProcess.Enabled = false;
            }
        }

        private void tmrPaint_Tick(object sender, EventArgs e)
        {
            oGL.Refresh();
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {

            if (!m_MouseHovering)
                return;

            float px = 100f / (float)oGL.Width * (float)m_LastMouseMovement.X;
            float py = 100f / (float)oGL.Height * (float)m_LastMouseMovement.Y;
            int x = 0;
            int y = 0;


            if (px > 90)
            {
                x = 100 - (int)px;
                m_PositionX += ((x * -1) + 9) * 2;
            }
            else if (px < 10)
            {
                x = (int)px;
                m_PositionX -= ((x * -1) + 9) * 2;
            }


            if (py > 90)
            {
                y = 100 - (int)py;
                m_PositionY += ((y * -1) + 9) * 2;
            }
            else if (py < 10)
            {
                y = (int)py;
                m_PositionY -= ((y * -1) + 9) * 2;
            }

            if (m_PositionY < 0)
                m_PositionY = 0;

            if (m_PositionX < 0)
                m_PositionX = 0;



        }

		#endregion Methods 

        private void chkViewPattern_Click(object sender, EventArgs e)
        {
            chkViewPattern.Checked = (!chkViewPattern.Checked);
        }

        private void ViewMenu_Clicked(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = (!((ToolStripMenuItem)sender).Checked);
        }

        private void ctlObjSelection1_Load(object sender, EventArgs e)
        {

        }
    }
}
