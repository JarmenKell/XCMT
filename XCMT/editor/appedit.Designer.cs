namespace XCMT.editor
{
    partial class appedit
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
            this.gridview = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.down = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.up = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.repeat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xkey = new System.Windows.Forms.ComboBox();
            this.xmouse = new System.Windows.Forms.ComboBox();
            this.xup = new System.Windows.Forms.CheckBox();
            this.xdown = new System.Windows.Forms.CheckBox();
            this.xtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xconfig = new System.Windows.Forms.ComboBox();
            this.mt_new = new System.Windows.Forms.Button();
            this.mt_change = new System.Windows.Forms.Button();
            this.mt_delete = new System.Windows.Forms.Button();
            this.conf_new = new System.Windows.Forms.Button();
            this.conf_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kradio = new System.Windows.Forms.RadioButton();
            this.mradio = new System.Windows.Forms.RadioButton();
            this.conf_rename = new System.Windows.Forms.Button();
            this.xindex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apptip = new System.Windows.Forms.ToolTip(this.components);
            this.mt_assist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xrepeat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.type,
            this.key,
            this.mouse,
            this.down,
            this.up,
            this.repeat});
            this.gridview.Location = new System.Drawing.Point(12, 102);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(642, 248);
            this.gridview.TabIndex = 0;
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 40;
            // 
            // type
            // 
            this.type.HeaderText = "Controller";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 140;
            // 
            // key
            // 
            this.key.HeaderText = "Tastatur";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Width = 130;
            // 
            // mouse
            // 
            this.mouse.HeaderText = "Maus";
            this.mouse.Name = "mouse";
            this.mouse.ReadOnly = true;
            this.mouse.Width = 110;
            // 
            // down
            // 
            this.down.HeaderText = "DOWN";
            this.down.Name = "down";
            this.down.ReadOnly = true;
            this.down.Width = 45;
            // 
            // up
            // 
            this.up.HeaderText = "UP";
            this.up.Name = "up";
            this.up.ReadOnly = true;
            this.up.Width = 45;
            // 
            // repeat
            // 
            this.repeat.HeaderText = "Wiederholen";
            this.repeat.Name = "repeat";
            this.repeat.Width = 70;
            // 
            // xkey
            // 
            this.xkey.FormattingEnabled = true;
            this.xkey.Location = new System.Drawing.Point(214, 66);
            this.xkey.Name = "xkey";
            this.xkey.Size = new System.Drawing.Size(120, 21);
            this.xkey.TabIndex = 1;
            // 
            // xmouse
            // 
            this.xmouse.FormattingEnabled = true;
            this.xmouse.Items.AddRange(new object[] {
            "MOVE_DOWN",
            "MOVE_LEFT",
            "MOVE_RIGHT",
            "MOVE_UP",
            "LEFT",
            "RIGHT",
            "MIDDLE",
            "X"});
            this.xmouse.Location = new System.Drawing.Point(340, 66);
            this.xmouse.Name = "xmouse";
            this.xmouse.Size = new System.Drawing.Size(98, 21);
            this.xmouse.TabIndex = 2;
            // 
            // xup
            // 
            this.xup.AutoSize = true;
            this.xup.Checked = true;
            this.xup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xup.Location = new System.Drawing.Point(511, 66);
            this.xup.Name = "xup";
            this.xup.Size = new System.Drawing.Size(41, 17);
            this.xup.TabIndex = 3;
            this.xup.Text = "UP";
            this.xup.UseVisualStyleBackColor = true;
            // 
            // xdown
            // 
            this.xdown.AutoSize = true;
            this.xdown.Checked = true;
            this.xdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xdown.Location = new System.Drawing.Point(444, 66);
            this.xdown.Name = "xdown";
            this.xdown.Size = new System.Drawing.Size(61, 17);
            this.xdown.TabIndex = 4;
            this.xdown.Text = "DOWN";
            this.xdown.UseVisualStyleBackColor = true;
            // 
            // xtype
            // 
            this.xtype.Location = new System.Drawing.Point(87, 66);
            this.xtype.Name = "xtype";
            this.xtype.Size = new System.Drawing.Size(121, 21);
            this.xtype.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Controller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Drücken | Loslassen";
            // 
            // xconfig
            // 
            this.xconfig.FormattingEnabled = true;
            this.xconfig.Location = new System.Drawing.Point(87, 12);
            this.xconfig.Name = "xconfig";
            this.xconfig.Size = new System.Drawing.Size(140, 21);
            this.xconfig.TabIndex = 12;
            this.xconfig.SelectedIndexChanged += new System.EventHandler(this.xconfig_SelectedIndexChanged);
            // 
            // mt_new
            // 
            this.mt_new.Location = new System.Drawing.Point(626, 12);
            this.mt_new.Name = "mt_new";
            this.mt_new.Size = new System.Drawing.Size(60, 24);
            this.mt_new.TabIndex = 14;
            this.mt_new.Text = "Neu";
            this.mt_new.UseVisualStyleBackColor = true;
            this.mt_new.Click += new System.EventHandler(this.mt_new_Click);
            // 
            // mt_change
            // 
            this.mt_change.Location = new System.Drawing.Point(626, 42);
            this.mt_change.Name = "mt_change";
            this.mt_change.Size = new System.Drawing.Size(60, 24);
            this.mt_change.TabIndex = 15;
            this.mt_change.Text = "Ändern";
            this.mt_change.UseVisualStyleBackColor = true;
            this.mt_change.Click += new System.EventHandler(this.mt_change_Click);
            // 
            // mt_delete
            // 
            this.mt_delete.Location = new System.Drawing.Point(626, 72);
            this.mt_delete.Name = "mt_delete";
            this.mt_delete.Size = new System.Drawing.Size(60, 24);
            this.mt_delete.TabIndex = 16;
            this.mt_delete.Text = "Löschen";
            this.mt_delete.UseVisualStyleBackColor = true;
            this.mt_delete.Click += new System.EventHandler(this.mt_delete_Click);
            // 
            // conf_new
            // 
            this.conf_new.Location = new System.Drawing.Point(233, 12);
            this.conf_new.Name = "conf_new";
            this.conf_new.Size = new System.Drawing.Size(75, 24);
            this.conf_new.TabIndex = 17;
            this.conf_new.Text = "Neue Konfig";
            this.conf_new.UseVisualStyleBackColor = true;
            this.conf_new.Click += new System.EventHandler(this.conf_new_Click);
            // 
            // conf_delete
            // 
            this.conf_delete.Location = new System.Drawing.Point(395, 12);
            this.conf_delete.Name = "conf_delete";
            this.conf_delete.Size = new System.Drawing.Size(90, 24);
            this.conf_delete.TabIndex = 18;
            this.conf_delete.Text = "Konfig Löschen";
            this.conf_delete.UseVisualStyleBackColor = true;
            this.conf_delete.Click += new System.EventHandler(this.conf_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Konfiguration";
            // 
            // kradio
            // 
            this.kradio.AutoSize = true;
            this.kradio.Location = new System.Drawing.Point(244, 49);
            this.kradio.Name = "kradio";
            this.kradio.Size = new System.Drawing.Size(64, 17);
            this.kradio.TabIndex = 21;
            this.kradio.Text = "Tastatur";
            this.kradio.UseVisualStyleBackColor = true;
            this.kradio.CheckedChanged += new System.EventHandler(this.kradio_CheckedChanged);
            // 
            // mradio
            // 
            this.mradio.AutoSize = true;
            this.mradio.Checked = true;
            this.mradio.Location = new System.Drawing.Point(364, 49);
            this.mradio.Name = "mradio";
            this.mradio.Size = new System.Drawing.Size(51, 17);
            this.mradio.TabIndex = 22;
            this.mradio.TabStop = true;
            this.mradio.Text = "Maus";
            this.mradio.UseVisualStyleBackColor = true;
            this.mradio.CheckedChanged += new System.EventHandler(this.mradio_CheckedChanged);
            // 
            // conf_rename
            // 
            this.conf_rename.Location = new System.Drawing.Point(314, 12);
            this.conf_rename.Name = "conf_rename";
            this.conf_rename.Size = new System.Drawing.Size(75, 24);
            this.conf_rename.TabIndex = 23;
            this.conf_rename.Text = "Umbennen";
            this.conf_rename.UseVisualStyleBackColor = true;
            this.conf_rename.Click += new System.EventHandler(this.conf_rename_Click);
            // 
            // xindex
            // 
            this.xindex.FormattingEnabled = true;
            this.xindex.Location = new System.Drawing.Point(15, 66);
            this.xindex.Name = "xindex";
            this.xindex.Size = new System.Drawing.Size(66, 21);
            this.xindex.TabIndex = 25;
            this.xindex.SelectedIndexChanged += new System.EventHandler(this.xindex_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Index";
            // 
            // mt_assist
            // 
            this.mt_assist.Location = new System.Drawing.Point(510, 12);
            this.mt_assist.Name = "mt_assist";
            this.mt_assist.Size = new System.Drawing.Size(97, 24);
            this.mt_assist.TabIndex = 28;
            this.mt_assist.Text = "Kombi Asistent";
            this.mt_assist.UseVisualStyleBackColor = true;
            this.mt_assist.Click += new System.EventHandler(this.mt_assist_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Wiederholen";
            // 
            // xrepeat
            // 
            this.xrepeat.AutoSize = true;
            this.xrepeat.Checked = true;
            this.xrepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xrepeat.Location = new System.Drawing.Point(575, 66);
            this.xrepeat.Name = "xrepeat";
            this.xrepeat.Size = new System.Drawing.Size(15, 14);
            this.xrepeat.TabIndex = 30;
            this.xrepeat.UseVisualStyleBackColor = true;
            // 
            // appedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 362);
            this.Controls.Add(this.xrepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mt_assist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xindex);
            this.Controls.Add(this.conf_rename);
            this.Controls.Add(this.mradio);
            this.Controls.Add(this.kradio);
            this.Controls.Add(this.conf_delete);
            this.Controls.Add(this.conf_new);
            this.Controls.Add(this.mt_delete);
            this.Controls.Add(this.mt_change);
            this.Controls.Add(this.mt_new);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xconfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xtype);
            this.Controls.Add(this.xdown);
            this.Controls.Add(this.xup);
            this.Controls.Add(this.xmouse);
            this.Controls.Add(this.xkey);
            this.Controls.Add(this.gridview);
            this.Name = "appedit";
            this.Text = "Anwendungsprofil Editor";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox xkey;
        private System.Windows.Forms.ComboBox xmouse;
        private System.Windows.Forms.CheckBox xup;
        private System.Windows.Forms.CheckBox xdown;
        private System.Windows.Forms.ComboBox xtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox xconfig;
        private System.Windows.Forms.Button mt_new;
        private System.Windows.Forms.Button mt_change;
        private System.Windows.Forms.Button mt_delete;
        private System.Windows.Forms.Button conf_new;
        private System.Windows.Forms.Button conf_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton kradio;
        private System.Windows.Forms.RadioButton mradio;
        private System.Windows.Forms.Button conf_rename;
        private System.Windows.Forms.ComboBox xindex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip apptip;
        private System.Windows.Forms.Button mt_assist;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox xrepeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn mouse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn down;
        private System.Windows.Forms.DataGridViewCheckBoxColumn up;
        private System.Windows.Forms.DataGridViewCheckBoxColumn repeat;
    }
}