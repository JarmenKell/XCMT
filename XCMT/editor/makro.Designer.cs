namespace XCMT.editor
{
    partial class makro
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
            this.mtype = new System.Windows.Forms.ComboBox();
            this.mkey = new System.Windows.Forms.ComboBox();
            this.mwin = new System.Windows.Forms.CheckBox();
            this.mshift = new System.Windows.Forms.CheckBox();
            this.mstrg = new System.Windows.Forms.CheckBox();
            this.malt = new System.Windows.Forms.CheckBox();
            this.insert = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // mtype
            // 
            this.mtype.Location = new System.Drawing.Point(12, 35);
            this.mtype.Name = "mtype";
            this.mtype.Size = new System.Drawing.Size(159, 21);
            this.mtype.TabIndex = 29;
            // 
            // mkey
            // 
            this.mkey.FormattingEnabled = true;
            this.mkey.Location = new System.Drawing.Point(12, 62);
            this.mkey.Name = "mkey";
            this.mkey.Size = new System.Drawing.Size(159, 21);
            this.mkey.TabIndex = 28;
            // 
            // mwin
            // 
            this.mwin.AutoSize = true;
            this.mwin.Location = new System.Drawing.Point(136, 12);
            this.mwin.Name = "mwin";
            this.mwin.Size = new System.Drawing.Size(45, 17);
            this.mwin.TabIndex = 33;
            this.mwin.Text = "Win";
            this.mwin.UseVisualStyleBackColor = true;
            // 
            // mshift
            // 
            this.mshift.AutoSize = true;
            this.mshift.Location = new System.Drawing.Point(91, 12);
            this.mshift.Name = "mshift";
            this.mshift.Size = new System.Drawing.Size(47, 17);
            this.mshift.TabIndex = 32;
            this.mshift.Text = "Shift";
            this.mshift.UseVisualStyleBackColor = true;
            // 
            // mstrg
            // 
            this.mstrg.AutoSize = true;
            this.mstrg.Location = new System.Drawing.Point(48, 12);
            this.mstrg.Name = "mstrg";
            this.mstrg.Size = new System.Drawing.Size(45, 17);
            this.mstrg.TabIndex = 31;
            this.mstrg.Text = "Strg";
            this.mstrg.UseVisualStyleBackColor = true;
            // 
            // malt
            // 
            this.malt.AutoSize = true;
            this.malt.Location = new System.Drawing.Point(12, 12);
            this.malt.Name = "malt";
            this.malt.Size = new System.Drawing.Size(38, 17);
            this.malt.TabIndex = 30;
            this.malt.Text = "Alt";
            this.malt.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(12, 89);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(72, 31);
            this.insert.TabIndex = 34;
            this.insert.Text = "Einfügen";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(99, 89);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(72, 31);
            this.abort.TabIndex = 35;
            this.abort.Text = "Abbrechen";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // makro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 129);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.mwin);
            this.Controls.Add(this.mshift);
            this.Controls.Add(this.mstrg);
            this.Controls.Add(this.malt);
            this.Controls.Add(this.mtype);
            this.Controls.Add(this.mkey);
            this.Name = "makro";
            this.Text = "makro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mtype;
        private System.Windows.Forms.ComboBox mkey;
        private System.Windows.Forms.CheckBox mwin;
        private System.Windows.Forms.CheckBox mshift;
        private System.Windows.Forms.CheckBox mstrg;
        private System.Windows.Forms.CheckBox malt;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}