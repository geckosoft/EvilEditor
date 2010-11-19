namespace EvilPlug.Editors.MapEditor
{
    partial class ctlObjSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picTile = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTile)).BeginInit();
            this.SuspendLayout();
            // 
            // picTile
            // 
            this.picTile.Location = new System.Drawing.Point(41, 5);
            this.picTile.Name = "picTile";
            this.picTile.Size = new System.Drawing.Size(64, 64);
            this.picTile.TabIndex = 0;
            this.picTile.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 42);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "line1\r\nline2\r\nline3\r\n";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctlObjSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picTile);
            this.Name = "ctlObjSelection";
            this.Size = new System.Drawing.Size(150, 121);
            ((System.ComponentModel.ISupportInitialize)(this.picTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picTile;
        public System.Windows.Forms.Label lblName;

    }
}
