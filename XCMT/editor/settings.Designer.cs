namespace XCMT.editor
{
    partial class settings
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.minterwall = new System.Windows.Forms.MaskedTextBox();
            this.mwidth = new System.Windows.Forms.MaskedTextBox();
            this.mheight = new System.Windows.Forms.MaskedTextBox();
            this.mposy = new System.Windows.Forms.MaskedTextBox();
            this.mposx = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mfps = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.settip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkey = new System.Windows.Forms.ComboBox();
            this.mwin = new System.Windows.Forms.CheckBox();
            this.mshift = new System.Windows.Forms.CheckBox();
            this.mstrg = new System.Windows.Forms.CheckBox();
            this.malt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mspeed = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minterwall
            // 
            this.minterwall.Location = new System.Drawing.Point(78, 12);
            this.minterwall.Mask = "000";
            this.minterwall.Name = "minterwall";
            this.minterwall.Size = new System.Drawing.Size(30, 20);
            this.minterwall.TabIndex = 1;
            // 
            // mwidth
            // 
            this.mwidth.Location = new System.Drawing.Point(78, 90);
            this.mwidth.Mask = "0000";
            this.mwidth.Name = "mwidth";
            this.mwidth.Size = new System.Drawing.Size(30, 20);
            this.mwidth.TabIndex = 2;
            // 
            // mheight
            // 
            this.mheight.Location = new System.Drawing.Point(78, 119);
            this.mheight.Mask = "0000";
            this.mheight.Name = "mheight";
            this.mheight.Size = new System.Drawing.Size(30, 20);
            this.mheight.TabIndex = 3;
            // 
            // mposy
            // 
            this.mposy.Location = new System.Drawing.Point(78, 64);
            this.mposy.Mask = "0000";
            this.mposy.Name = "mposy";
            this.mposy.Size = new System.Drawing.Size(30, 20);
            this.mposy.TabIndex = 4;
            // 
            // mposx
            // 
            this.mposx.Location = new System.Drawing.Point(78, 38);
            this.mposx.Mask = "0000";
            this.mposx.Name = "mposx";
            this.mposx.Size = new System.Drawing.Size(30, 20);
            this.mposx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tickzeit ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Breite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Höhe";
            // 
            // mfps
            // 
            this.mfps.AutoSize = true;
            this.mfps.Location = new System.Drawing.Point(114, 15);
            this.mfps.Name = "mfps";
            this.mfps.Size = new System.Drawing.Size(42, 13);
            this.mfps.TabIndex = 11;
            this.mfps.Text = "00 FPS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "pixel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "pixel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "pixel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "pixel";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 260);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(72, 24);
            this.save.TabIndex = 16;
            this.save.Text = "Speichern";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(115, 260);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(72, 24);
            this.abort.TabIndex = 17;
            this.abort.Text = "Abbrechen";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mkey);
            this.groupBox1.Controls.Add(this.mwin);
            this.groupBox1.Controls.Add(this.mshift);
            this.groupBox1.Controls.Add(this.mstrg);
            this.groupBox1.Controls.Add(this.malt);
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 69);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkey";
            // 
            // mkey
            // 
            this.mkey.FormattingEnabled = true;
            this.mkey.Location = new System.Drawing.Point(6, 42);
            this.mkey.Name = "mkey";
            this.mkey.Size = new System.Drawing.Size(163, 21);
            this.mkey.TabIndex = 4;
            // 
            // mwin
            // 
            this.mwin.AutoSize = true;
            this.mwin.Location = new System.Drawing.Point(130, 19);
            this.mwin.Name = "mwin";
            this.mwin.Size = new System.Drawing.Size(45, 17);
            this.mwin.TabIndex = 3;
            this.mwin.Text = "Win";
            this.mwin.UseVisualStyleBackColor = true;
            // 
            // mshift
            // 
            this.mshift.AutoSize = true;
            this.mshift.Location = new System.Drawing.Point(85, 19);
            this.mshift.Name = "mshift";
            this.mshift.Size = new System.Drawing.Size(47, 17);
            this.mshift.TabIndex = 2;
            this.mshift.Text = "Shift";
            this.mshift.UseVisualStyleBackColor = true;
            // 
            // mstrg
            // 
            this.mstrg.AutoSize = true;
            this.mstrg.Location = new System.Drawing.Point(42, 19);
            this.mstrg.Name = "mstrg";
            this.mstrg.Size = new System.Drawing.Size(45, 17);
            this.mstrg.TabIndex = 1;
            this.mstrg.Text = "Strg";
            this.mstrg.UseVisualStyleBackColor = true;
            // 
            // malt
            // 
            this.malt.AutoSize = true;
            this.malt.Location = new System.Drawing.Point(6, 19);
            this.malt.Name = "malt";
            this.malt.Size = new System.Drawing.Size(38, 17);
            this.malt.TabIndex = 0;
            this.malt.Text = "Alt";
            this.malt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mausgesch -windigkeit";
            // 
            // mspeed
            // 
            this.mspeed.Location = new System.Drawing.Point(78, 145);
            this.mspeed.Mask = "00";
            this.mspeed.Name = "mspeed";
            this.mspeed.Size = new System.Drawing.Size(30, 20);
            this.mspeed.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "relativ";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 296);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mspeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mfps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mposx);
            this.Controls.Add(this.mposy);
            this.Controls.Add(this.mheight);
            this.Controls.Add(this.mwidth);
            this.Controls.Add(this.minterwall);
            this.Name = "settings";
            this.Text = "Einstellung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox minterwall;
        private System.Windows.Forms.MaskedTextBox mwidth;
        private System.Windows.Forms.MaskedTextBox mheight;
        private System.Windows.Forms.MaskedTextBox mposy;
        private System.Windows.Forms.MaskedTextBox mposx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mfps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.ToolTip settip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox malt;
        private System.Windows.Forms.CheckBox mwin;
        private System.Windows.Forms.CheckBox mshift;
        private System.Windows.Forms.CheckBox mstrg;
        private System.Windows.Forms.ComboBox mkey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mspeed;
        private System.Windows.Forms.Label label11;

    }
}