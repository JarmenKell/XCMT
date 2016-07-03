namespace XCMT.editor
{
    partial class config
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
            this.cdownup = new System.Windows.Forms.TextBox();
            this.cmousekey = new System.Windows.Forms.TextBox();
            this.ccontrol = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.Label();
            this.crepeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cdownup
            // 
            this.cdownup.BackColor = System.Drawing.Color.White;
            this.cdownup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdownup.Enabled = false;
            this.cdownup.Location = new System.Drawing.Point(209, 13);
            this.cdownup.Margin = new System.Windows.Forms.Padding(0);
            this.cdownup.Multiline = true;
            this.cdownup.Name = "cdownup";
            this.cdownup.Size = new System.Drawing.Size(74, 20);
            this.cdownup.TabIndex = 7;
            // 
            // cmousekey
            // 
            this.cmousekey.BackColor = System.Drawing.Color.White;
            this.cmousekey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmousekey.Enabled = false;
            this.cmousekey.Location = new System.Drawing.Point(110, 13);
            this.cmousekey.Margin = new System.Windows.Forms.Padding(0);
            this.cmousekey.Multiline = true;
            this.cmousekey.Name = "cmousekey";
            this.cmousekey.Size = new System.Drawing.Size(99, 20);
            this.cmousekey.TabIndex = 6;
            // 
            // ccontrol
            // 
            this.ccontrol.BackColor = System.Drawing.Color.White;
            this.ccontrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ccontrol.Enabled = false;
            this.ccontrol.Location = new System.Drawing.Point(1, 13);
            this.ccontrol.Margin = new System.Windows.Forms.Padding(0);
            this.ccontrol.Multiline = true;
            this.ccontrol.Name = "ccontrol";
            this.ccontrol.Size = new System.Drawing.Size(109, 20);
            this.ccontrol.TabIndex = 5;
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Enabled = false;
            this.cname.Location = new System.Drawing.Point(-2, 0);
            this.cname.Margin = new System.Windows.Forms.Padding(0);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(102, 13);
            this.cname.TabIndex = 4;
            this.cname.Text = "Globale Konfigurtion";
            // 
            // crepeat
            // 
            this.crepeat.BackColor = System.Drawing.Color.White;
            this.crepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crepeat.Enabled = false;
            this.crepeat.Location = new System.Drawing.Point(283, 13);
            this.crepeat.Margin = new System.Windows.Forms.Padding(0);
            this.crepeat.Multiline = true;
            this.crepeat.Name = "crepeat";
            this.crepeat.Size = new System.Drawing.Size(74, 20);
            this.crepeat.TabIndex = 8;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(357, 36);
            this.Controls.Add(this.crepeat);
            this.Controls.Add(this.cdownup);
            this.Controls.Add(this.cmousekey);
            this.Controls.Add(this.ccontrol);
            this.Controls.Add(this.cname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cdownup;
        private System.Windows.Forms.TextBox cmousekey;
        private System.Windows.Forms.TextBox ccontrol;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.TextBox crepeat;

    }
}