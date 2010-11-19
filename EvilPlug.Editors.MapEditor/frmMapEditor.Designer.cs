namespace EvilPlug.Editors.MapEditor
{
    partial class frmMapEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.maToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawSoimethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkViewPattern = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkViewMap = new System.Windows.Forms.ToolStripMenuItem();
            this.chkViewObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtSearchit = new System.Windows.Forms.ToolStripTextBox();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.grpSelected = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.oGL = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.mnuTools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTileMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrLoadProcess = new System.Windows.Forms.Timer(this.components);
            this.tmrPaint = new System.Windows.Forms.Timer(this.components);
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.mainStatusStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.mnuTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 533);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(842, 22);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 17);
            this.lblStatus.Text = "Status: Idle";
            // 
            // mainMenu
            // 
            this.mainMenu.AllowMerge = false;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(842, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // maToolStripMenuItem
            // 
            this.maToolStripMenuItem.Name = "maToolStripMenuItem";
            this.maToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.maToolStripMenuItem.Text = "Map";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawSoimethingToolStripMenuItem,
            this.chkViewPattern});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // drawSoimethingToolStripMenuItem
            // 
            this.drawSoimethingToolStripMenuItem.Name = "drawSoimethingToolStripMenuItem";
            this.drawSoimethingToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.drawSoimethingToolStripMenuItem.Text = "Draw Something";
            this.drawSoimethingToolStripMenuItem.Click += new System.EventHandler(this.drawSoimethingToolStripMenuItem_Click);
            // 
            // chkViewPattern
            // 
            this.chkViewPattern.Name = "chkViewPattern";
            this.chkViewPattern.Size = new System.Drawing.Size(232, 22);
            this.chkViewPattern.Text = "View Patterns (Screen control)";
            this.chkViewPattern.Click += new System.EventHandler(this.chkViewPattern_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkViewMap,
            this.chkViewObjects});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // chkViewMap
            // 
            this.chkViewMap.Checked = true;
            this.chkViewMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkViewMap.Name = "chkViewMap";
            this.chkViewMap.Size = new System.Drawing.Size(114, 22);
            this.chkViewMap.Text = "&Map";
            this.chkViewMap.Click += new System.EventHandler(this.ViewMenu_Clicked);
            // 
            // chkViewObjects
            // 
            this.chkViewObjects.Name = "chkViewObjects";
            this.chkViewObjects.Size = new System.Drawing.Size(114, 22);
            this.chkViewObjects.Text = "&Objects";
            this.chkViewObjects.Click += new System.EventHandler(this.ViewMenu_Clicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearchit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtSearchit
            // 
            this.txtSearchit.Name = "txtSearchit";
            this.txtSearchit.Size = new System.Drawing.Size(100, 25);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(0, 49);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.pnlScroll);
            this.splitMain.Panel1.Controls.Add(this.grpSelected);
            this.splitMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitMain.Panel2.Controls.Add(this.oGL);
            this.splitMain.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitMain.Size = new System.Drawing.Size(842, 484);
            this.splitMain.SplitterDistance = 177;
            this.splitMain.TabIndex = 4;
            // 
            // pnlScroll
            // 
            this.pnlScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Location = new System.Drawing.Point(0, 49);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(177, 326);
            this.pnlScroll.TabIndex = 4;
            // 
            // grpSelected
            // 
            this.grpSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelected.Controls.Add(this.pictureBox1);
            this.grpSelected.Location = new System.Drawing.Point(0, 375);
            this.grpSelected.Name = "grpSelected";
            this.grpSelected.Size = new System.Drawing.Size(177, 109);
            this.grpSelected.TabIndex = 2;
            this.grpSelected.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // oGL
            // 
            this.oGL.AccumBits = ((byte)(0));
            this.oGL.AutoCheckErrors = false;
            this.oGL.AutoFinish = true;
            this.oGL.AutoMakeCurrent = true;
            this.oGL.AutoSize = true;
            this.oGL.AutoSwapBuffers = true;
            this.oGL.BackColor = System.Drawing.Color.Black;
            this.oGL.ColorBits = ((byte)(16));
            this.oGL.ContextMenuStrip = this.mnuTools;
            this.oGL.DepthBits = ((byte)(16));
            this.oGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oGL.Location = new System.Drawing.Point(0, 0);
            this.oGL.Name = "oGL";
            this.oGL.Size = new System.Drawing.Size(661, 484);
            this.oGL.StencilBits = ((byte)(0));
            this.oGL.TabIndex = 3;
            this.oGL.Load += new System.EventHandler(this.simpleOpenGlControl1_Load);
            this.oGL.MouseLeave += new System.EventHandler(this.oGL_MouseLeave);
            this.oGL.Paint += new System.Windows.Forms.PaintEventHandler(this.oGL_Paint);
            this.oGL.Click += new System.EventHandler(this.oGL_Click_1);
            this.oGL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oGL_MouseMove);
            this.oGL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oGL_MouseClick);
            this.oGL.Resize += new System.EventHandler(this.oGL_Resize_1);
            this.oGL.MouseHover += new System.EventHandler(this.oGL_MouseHover);
            this.oGL.MouseEnter += new System.EventHandler(this.oGL_MouseEnter);
            // 
            // mnuTools
            // 
            this.mnuTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTileMenuEntry,
            this.toolStripMenuItem1,
            this.mnuObjects});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(173, 54);
            this.mnuTools.Opening += new System.ComponentModel.CancelEventHandler(this.mnuTools_Opening);
            // 
            // lblTileMenuEntry
            // 
            this.lblTileMenuEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTileMenuEntry.Checked = true;
            this.lblTileMenuEntry.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.lblTileMenuEntry.Name = "lblTileMenuEntry";
            this.lblTileMenuEntry.Size = new System.Drawing.Size(172, 22);
            this.lblTileMenuEntry.Text = "Tile 5000 (500x500)";
            this.lblTileMenuEntry.Click += new System.EventHandler(this.helloToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuObjects
            // 
            this.mnuObjects.Name = "mnuObjects";
            this.mnuObjects.Size = new System.Drawing.Size(172, 22);
            this.mnuObjects.Text = "Objects...";
            // 
            // tmrLoadProcess
            // 
            this.tmrLoadProcess.Enabled = true;
            this.tmrLoadProcess.Interval = 1000;
            this.tmrLoadProcess.Tick += new System.EventHandler(this.tmrLoadProcess_Tick);
            // 
            // tmrPaint
            // 
            this.tmrPaint.Enabled = true;
            this.tmrPaint.Interval = 1;
            this.tmrPaint.Tick += new System.EventHandler(this.tmrPaint_Tick);
            // 
            // tmrScroll
            // 
            this.tmrScroll.Enabled = true;
            this.tmrScroll.Interval = 10;
            this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
            // 
            // frmMapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 555);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMapEditor";
            this.Text = "frmMapEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmMapEditor_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMapEditor_FormClosing);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.Panel2.PerformLayout();
            this.splitMain.ResumeLayout(false);
            this.grpSelected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnuTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem maToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Timer tmrLoadProcess;
        private System.Windows.Forms.Timer tmrPaint;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawSoimethingToolStripMenuItem;
        private Tao.Platform.Windows.SimpleOpenGlControl oGL;
        private System.Windows.Forms.ContextMenuStrip mnuTools;
        private System.Windows.Forms.ToolStripMenuItem lblTileMenuEntry;
        private System.Windows.Forms.ToolStripTextBox txtSearchit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Timer tmrScroll;
        private System.Windows.Forms.ToolStripMenuItem chkViewPattern;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chkViewMap;
        private System.Windows.Forms.ToolStripMenuItem chkViewObjects;
        private System.Windows.Forms.ToolStripMenuItem mnuObjects;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlScroll;
    }
}