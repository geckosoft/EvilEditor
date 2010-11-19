namespace EvilPlug.Editors.MapEditor
{
    partial class frmTileDetail
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
            this.pnlCloseButton = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTileId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCloseButton.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCloseButton
            // 
            this.pnlCloseButton.Controls.Add(this.btnDetails);
            this.pnlCloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCloseButton.Location = new System.Drawing.Point(0, 47);
            this.pnlCloseButton.Name = "pnlCloseButton";
            this.pnlCloseButton.Size = new System.Drawing.Size(425, 30);
            this.pnlCloseButton.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetails.Location = new System.Drawing.Point(0, 0);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(425, 30);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Close";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTileId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtTileId
            // 
            this.txtTileId.Enabled = false;
            this.txtTileId.Location = new System.Drawing.Point(47, 16);
            this.txtTileId.Name = "txtTileId";
            this.txtTileId.Size = new System.Drawing.Size(372, 20);
            this.txtTileId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tile id";
            // 
            // frmTileDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 77);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlCloseButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTileDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details for tile found at position ";
            this.pnlCloseButton.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCloseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTileId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetails;
    }
}