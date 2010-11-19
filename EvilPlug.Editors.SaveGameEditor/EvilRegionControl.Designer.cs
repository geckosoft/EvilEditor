namespace EvilPlug.Editors.SaveGameEditor
{
    partial class EvilRegionControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotoriety = new System.Windows.Forms.TextBox();
            this.txtHeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTouristNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAUnlocked = new System.Windows.Forms.CheckBox();
            this.chkADefeated = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkADefeated);
            this.groupBox1.Controls.Add(this.chkAUnlocked);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTouristNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNotoriety);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A.N.V.I.L.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notoriety";
            // 
            // txtNotoriety
            // 
            this.txtNotoriety.Location = new System.Drawing.Point(98, 19);
            this.txtNotoriety.Name = "txtNotoriety";
            this.txtNotoriety.Size = new System.Drawing.Size(100, 20);
            this.txtNotoriety.TabIndex = 1;
            this.txtNotoriety.Tag = "Notoriety";
            this.txtNotoriety.TextChanged += new System.EventHandler(this.txtNotoriety_TextChanged);
            // 
            // txtHeat
            // 
            this.txtHeat.Location = new System.Drawing.Point(98, 45);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(100, 20);
            this.txtHeat.TabIndex = 3;
            this.txtHeat.Tag = "Heat";
            this.txtHeat.TextChanged += new System.EventHandler(this.txtNotoriety_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Heat";
            // 
            // txtTouristNumber
            // 
            this.txtTouristNumber.Location = new System.Drawing.Point(98, 71);
            this.txtTouristNumber.Name = "txtTouristNumber";
            this.txtTouristNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTouristNumber.TabIndex = 5;
            this.txtTouristNumber.Tag = "Tourist";
            this.txtTouristNumber.TextChanged += new System.EventHandler(this.txtNotoriety_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tourist number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Regional Super-Agent";
            // 
            // chkAUnlocked
            // 
            this.chkAUnlocked.AutoSize = true;
            this.chkAUnlocked.Location = new System.Drawing.Point(313, 43);
            this.chkAUnlocked.Name = "chkAUnlocked";
            this.chkAUnlocked.Size = new System.Drawing.Size(86, 17);
            this.chkAUnlocked.TabIndex = 7;
            this.chkAUnlocked.Text = "is unlocked?";
            this.chkAUnlocked.UseVisualStyleBackColor = true;
            this.chkAUnlocked.CheckedChanged += new System.EventHandler(this.chkAUnlocked_CheckedChanged);
            // 
            // chkADefeated
            // 
            this.chkADefeated.AutoSize = true;
            this.chkADefeated.Location = new System.Drawing.Point(313, 69);
            this.chkADefeated.Name = "chkADefeated";
            this.chkADefeated.Size = new System.Drawing.Size(84, 17);
            this.chkADefeated.TabIndex = 8;
            this.chkADefeated.Text = "is defeated?";
            this.chkADefeated.UseVisualStyleBackColor = true;
            this.chkADefeated.CheckedChanged += new System.EventHandler(this.chkADefeated_CheckedChanged);
            // 
            // EvilRegionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "EvilRegionControl";
            this.Size = new System.Drawing.Size(474, 110);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAUnlocked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTouristNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotoriety;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkADefeated;
    }
}
