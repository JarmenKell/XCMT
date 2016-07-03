using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using XCMT.helper;

namespace XCMT.editor
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            minterwall.TextChanged += new EventHandler(minterwall_TextChanged);
            this.FormClosed += new FormClosedEventHandler(settings_FormClosed);
            mkey.KeyUp += new KeyEventHandler(mkey_KeyUp);

            for (byte i = 0; i < hash.key_.Length; i++) mkey.Items.Add(hash.key_[i]);
            mkey.Items.Remove("ALT");
            mkey.Items.Remove("Left Windows");
            mkey.Items.Remove("Right Windows");
            mkey.Items.Remove("CTRL");
            mkey.Items.Remove("Left CONTROL");
            mkey.Items.Remove("Right CONTROL");
            mkey.Items.Remove("SHIFT");
            mkey.Items.Remove("Left SHIFT");
            mkey.Items.Remove("Right SHIFT");
            mkey.Items.Remove("Left Windows");
            mkey.Items.Remove("Right Windows");
            mkey.SelectedIndex = 0;

            settip.SetToolTip(minterwall, "Angabe in ms zwischen den simulierten Tastendrücken/Mausklicks");
            settip.SetToolTip(mposx, "X Position des Anzeigefensters");
            settip.SetToolTip(mposy, "Y Position des Anzeigefensters");
            settip.SetToolTip(mwidth, "Breite des Anzeigefensters");
            settip.SetToolTip(mheight, "Höhe des Anzeigefensters");
            settip.SetToolTip(mspeed, "Die Mausgeschwindigkeit hängt auch von der im System eingestellten Zeigergeschwindigkeit ab");
            settip.SetToolTip(groupBox1, "Der Hotkey um das Anzeigefenster für die aktuelle(n) Konfiguration(en) ein/aus zublenden");

            minterwall.Text = Properties.Settings.Default.intervall.ToString();
            mposx.Text = Properties.Settings.Default.posx.ToString();
            mposy.Text = Properties.Settings.Default.posy.ToString();
            mwidth.Text = Properties.Settings.Default.widh.ToString();
            mheight.Text = Properties.Settings.Default.height.ToString();
            mspeed.Text = Properties.Settings.Default.speed.ToString();
            mkey.SelectedItem = hash.code_key[Properties.Settings.Default.hotkey];

            byte modifier = Properties.Settings.Default.modifer;
            #region switch (modifier)
            switch (modifier)
            {
                case 1:
                    malt.CheckState = CheckState.Checked;
                    break;

                case 2:
                    mstrg.CheckState = CheckState.Checked;
                    break;

                case 3:
                    malt.CheckState = CheckState.Checked;
                    mstrg.CheckState = CheckState.Checked;
                    break;

                case 4:
                    mshift.CheckState = CheckState.Checked;
                    break;

                case 5:
                    malt.CheckState = CheckState.Checked;
                    mshift.CheckState = CheckState.Checked;
                    break;

                case 6:
                    mstrg.CheckState = CheckState.Checked;
                    mshift.CheckState = CheckState.Checked;
                    break;

                case 7:
                    malt.CheckState = CheckState.Checked;
                    mstrg.CheckState = CheckState.Checked;
                    mshift.CheckState = CheckState.Checked;
                    break;

                case 8:
                    mwin.CheckState = CheckState.Checked;
                    break;

                case 9:
                    malt.CheckState = CheckState.Checked;
                    mwin.CheckState = CheckState.Checked;
                    break;

                case 10:
                    mstrg.CheckState = CheckState.Checked;
                    mwin.CheckState = CheckState.Checked;
                    break;

                case 11:
                    malt.CheckState = CheckState.Checked;
                    mstrg.CheckState = CheckState.Checked;
                    mwin.CheckState = CheckState.Checked;
                    break;

                case 12:
                    mshift.CheckState = CheckState.Checked;
                    mwin.CheckState = CheckState.Checked;
                    break;

                case 13:
                    malt.CheckState = CheckState.Checked;
                    mshift.CheckState = CheckState.Checked;
                    mwin.CheckState = CheckState.Checked;
                    break;

                case 14:
                    mstrg.CheckState = CheckState.Checked;
                    mshift.CheckState = CheckState.Checked;
                    mwin.CheckState = CheckState.Checked;
                    break;

                case 15:
                    malt.CheckState = CheckState.Checked;
                    mstrg.CheckState = CheckState.Checked;
                    mshift.CheckState = CheckState.Checked;
                    mwin.CheckState = CheckState.Checked;
                    break;
            }
            #endregion
        }

        void mkey_KeyUp(object sender, KeyEventArgs e)
        {
            mkey.SelectedItem = hash.code_key[(byte)e.KeyCode];
        }

        void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            XCMT.Code.trayform.set_enable = true;
        }

        void minterwall_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mfps.Text = (1000 / int.Parse(minterwall.Text)).ToString() + " FPS";
                save.Enabled = true;
            }
            catch(Exception)
            {
                save.Enabled = false;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            byte modifer = 0;
            if (malt.Checked) modifer += 1;
            if (mstrg.Checked) modifer += 2;
            if (mshift.Checked) modifer += 4;
            if (mwin.Checked) modifer += 8;

            Properties.Settings.Default.intervall = byte.Parse(minterwall.Text);
            Properties.Settings.Default.posx = short.Parse(mposx.Text);
            Properties.Settings.Default.posy = short.Parse(mposy.Text);
            Properties.Settings.Default.widh = short.Parse(mwidth.Text);
            Properties.Settings.Default.height = short.Parse(mheight.Text);
            Properties.Settings.Default.hotkey = (byte)hash.key_code[mkey.SelectedItem];
            Properties.Settings.Default.modifer = modifer;
            Properties.Settings.Default.speed = byte.Parse(mspeed.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
