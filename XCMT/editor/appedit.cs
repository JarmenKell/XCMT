using System;
using System.Windows.Forms;
using System.Collections;
using XCMT.Code;
using XCMT.helper;

namespace XCMT.editor
{
    public partial class appedit : Form
    {
        public static byte modifier;
        public static Microsoft.Xna.Framework.Input.Buttons controller_;
        public static byte key_;
        int xi;

        public appedit()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(appedit_FormClosing);
            //tickmain.intervall.Change(System.Threading.Timeout.Infinite, Properties.Settings.Default.intervall);
            xconfig.TextUpdate += new EventHandler(xconfig_TextUpdate); //sonst wäre index -1 vor der zweiten änderung
            gridview.SelectionChanged += new EventHandler(gridview_SelectionChanged);
            xkey.KeyUp += new KeyEventHandler(xkey_KeyUp);

            #region tooltip
            apptip.SetToolTip(xconfig, "Name der Konfiguration ist auch der Name des Programms");
            apptip.SetToolTip(xindex, "Nummer der Tasten/Mausbelegung");
            apptip.SetToolTip(xtype, "Stick/Trigger/Button auf den reagiert werden soll");
            apptip.SetToolTip(xkey, "zugeordnete Taste");
            apptip.SetToolTip(xmouse, "zugeordnete Maustaste");
            apptip.SetToolTip(xdown, "drücken der taste/klicken der maus");
            apptip.SetToolTip(xup, "loslassen der taste/maus");
            #endregion

            #region xtype.Items
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.A);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.B);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.Back);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.BigButton);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadDown);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadLeft);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadRight);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadUp);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftShoulder);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftStick);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickDown);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickLeft);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickRight);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickUp);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftTrigger);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightShoulder);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightStick);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickDown);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickLeft);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickRight);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickUp);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightTrigger);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.Start);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.X);
            xtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.Y);
            #endregion

            for (byte i = 0; i < hash.key_.Length; i++) xkey.Items.Add(hash.key_[i]);
            xkey.SelectedIndex = 0;
            xmouse.SelectedIndex = 0;
            xtype.SelectedIndex = 0;

            for (byte i = 0; i < tickmain.apps.Length; i++) xconfig.Items.Add(tickmain.apps[i].name);
            xconfig.SelectedIndex = 0;
        }

        void xkey_KeyUp(object sender, KeyEventArgs e)
        {
            xkey.SelectedItem = hash.code_key[(byte)e.KeyCode];
        }

        void gridview_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                xindex.SelectedIndex = gridview.SelectedCells[0].RowIndex;
            }
            catch { }
        }

        void xconfig_TextUpdate(object sender, EventArgs e)
        {
            if (xconfig.SelectedIndex != -1) xi = xconfig.SelectedIndex;
        }

        void appedit_FormClosing(object sender, FormClosingEventArgs e)
        {
            xdata.Serialize();
            trayform.edit_enable = true;
            //tickmain.intervall.Change(0, Properties.Settings.Default.intervall);
        }

        private void conf_new_Click(object sender, EventArgs e)
        {
            byte i = (byte)tickmain.apps.Length;
            Array.Resize(ref tickmain.apps, i + 1);
            tickmain.apps[i].add(xconfig.Text);
            xconfig.Items.Add(xconfig.Text);
            xconfig.SelectedItem = xconfig.Text;
        }

        private void conf_rename_Click(object sender, EventArgs e)
        {
            xconfig.Items[xi] = xconfig.Text;
            tickmain.apps[xi].name = xconfig.Text;
        }

        private void conf_delete_Click(object sender, EventArgs e)
        {
            xi = xconfig.SelectedIndex;
            xconfig.Items.RemoveAt(xi);

            int i;
            for (i = xi; i < xconfig.Items.Count; i++)
            {
                tickmain.apps[i] = tickmain.apps[i+1];
            }
            Array.Resize(ref tickmain.apps, tickmain.apps.Length - 1);

            if (xi == 0) xi = 1;
            xconfig.SelectedIndex = xi - 1;
        }

        private void mt_new_Click(object sender, EventArgs e)
        {
            int i = gridview.Rows.Count - 1;
            int x = xconfig.SelectedIndex;

            //neues mt nachdem mt im apps[i] um eins erweitert wurde
            Array.Resize(ref tickmain.apps[x].mt, tickmain.apps[x].mt.Length + 1);
            tickmain.apps[x].mt[i].change((Microsoft.Xna.Framework.Input.Buttons)xtype.SelectedItem, kradio.Checked, (byte)hash.key_code[xkey.SelectedItem], xmouse.SelectedItem.ToString(), xdown.CheckState, xup.CheckState, xrepeat.Checked);
            mt_new_(i);
        }

        private void mt_change_Click(object sender, EventArgs e)
        {
            int i = xindex.SelectedIndex;
            int x = xconfig.SelectedIndex;

            tickmain.apps[x].mt[i].change((Microsoft.Xna.Framework.Input.Buttons)xtype.SelectedItem, kradio.Checked, (byte)hash.key_code[xkey.SelectedItem], xmouse.SelectedItem.ToString(), xdown.CheckState, xup.CheckState, xrepeat.Checked);
            mt_change_(i);
        }

        private void mt_delete_Click(object sender, EventArgs e)
        {
            byte sx = (byte)xindex.SelectedIndex;
            tickmain.apps[xconfig.SelectedIndex].mt_delete(sx, xindex.Items.Count - 1);
            xconfig_SelectedIndexChanged(null, EventArgs.Empty);
            if (sx == xindex.Items.Count) sx--;
            gridview.Rows[0].Cells[0].Selected = false;
            gridview.Rows[sx].Selected = true;
        }

        private void xindex_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = xconfig.SelectedIndex;
            int x2 = xindex.SelectedIndex;

            xtype.SelectedItem = tickmain.apps[x].mt[x2].button;

            if (tickmain.apps[x].mt[x2].press & !tickmain.apps[x].mt[x2].release)
            {
                xdown.Checked = true;
                xup.Checked = false;

            }
            else if (!tickmain.apps[x].mt[x2].press  & tickmain.apps[x].mt[x2].release)
            {
                xdown.Checked = false;
                xup.Checked = true;
            }
            else
            {
                xdown.Checked = true;
                xup.Checked = true;
            }

            if (tickmain.apps[x].mt[x2].mouse != "")
            {
                mradio.Checked = true;
                xkey.SelectedItem = 0;
                xmouse.SelectedItem = tickmain.apps[x].mt[x2].mouse;
            }
            else
            {
                mradio.Checked = false;
            }

            if (tickmain.apps[x].mt[x2].key != 0)
            {
                kradio.Checked = true;
                xkey.SelectedItem = hash.code_key[tickmain.apps[x].mt[x2].key];
                xmouse.SelectedItem = "";
            }
            else
            {
                kradio.Checked = false;
            }

            if (tickmain.apps[x].mt[x2].repeat) xrepeat.Checked = true;
            else xrepeat.Checked = false;
        }

        private void xconfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = xconfig.SelectedIndex;

            //wenn andere config ausgewählt die combos etc neu bestücken
            xindex.Items.Clear();
            gridview.Rows.Clear();
            for (byte i = 0; i < tickmain.apps[x].mt.Length; i++) xindex.Items.Add(i);
            xindex.SelectedIndex = 0;
            gridview.Rows.Add(tickmain.apps[x].mt.Length);
            for (byte i = 0; i < tickmain.apps[x].mt.Length; i++)
            {
                gridview.Rows[i].Cells[0].Value = i;
                gridview.Rows[i].Cells[1].Value = tickmain.apps[x].mt[i].button;
                gridview.Rows[i].Cells[2].Value = hash.code_key[tickmain.apps[x].mt[i].key];
                gridview.Rows[i].Cells[3].Value = tickmain.apps[x].mt[i].mouse;

                if (tickmain.apps[x].mt[i].press & !tickmain.apps[x].mt[i].release)
                {
                    gridview.Rows[i].Cells[4].Value = CheckState.Checked;
                    gridview.Rows[i].Cells[5].Value = CheckState.Unchecked;
                }
                else if (!tickmain.apps[x].mt[i].press & tickmain.apps[x].mt[i].release)
                {
                    gridview.Rows[i].Cells[4].Value = CheckState.Unchecked;
                    gridview.Rows[i].Cells[5].Value = CheckState.Checked;
                }
                else
                {
                    gridview.Rows[i].Cells[4].Value = CheckState.Checked;
                    gridview.Rows[i].Cells[5].Value = CheckState.Checked;
                }

                if (tickmain.apps[x].mt[i].repeat) gridview.Rows[i].Cells[6].Value = CheckState.Checked;
                else gridview.Rows[i].Cells[6].Value = CheckState.Unchecked;
            }
        }

        private void kradio_CheckedChanged(object sender, EventArgs e)
        {
            if (kradio.Checked)
            {
                xkey.Enabled = true;
            }
            else
            {
                xkey.Enabled = false;
            }
        }

        private void mradio_CheckedChanged(object sender, EventArgs e)
        {
            if (mradio.Checked)
            {
                xmouse.Enabled = true;
            }
            else
            {
                xmouse.Enabled = false;
            }
        }

        private void mt_assist_Click(object sender, EventArgs e)
        {
            makro assist = new makro();
            assist.ShowDialog();

            if (assist.DialogResult == DialogResult.OK)
            {
                int a = xconfig.SelectedIndex;
                int m = xindex.Items.Count;

                #region switch (modifier)
                switch (modifier)
                {
                    case 1:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 3);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    case 2:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 3);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        break;

                    case 3:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 5);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+3].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    case 4:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 3);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        break;

                    case 5:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 5);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+3].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    case 6:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 5);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+3].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        break;

                    case 7:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 7);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+3].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        tickmain.apps[a].mt[m+5].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        tickmain.apps[a].mt[m+6].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    case 8:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 3);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        break;

                    case 9:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 5);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+3].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    case 10:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 5);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+3].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        break;

                    case 11:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 7);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+3].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        tickmain.apps[a].mt[m+5].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        tickmain.apps[a].mt[m+6].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    case 12:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 5);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+3].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        break;

                    case 13:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 7);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+3].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        tickmain.apps[a].mt[m+5].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        tickmain.apps[a].mt[m+6].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    case 14:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 7);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+3].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+4].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        tickmain.apps[a].mt[m+5].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        tickmain.apps[a].mt[m+6].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        break;

                    case 15:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 9);
                        tickmain.apps[a].mt[m].change(controller_, (byte)hash.key_code["ALT"], true, false);
                        tickmain.apps[a].mt[m+1].change(controller_, (byte)hash.key_code["CTRL"], true, false);
                        tickmain.apps[a].mt[m+2].change(controller_, (byte)hash.key_code["SHIFT"], true, false);
                        tickmain.apps[a].mt[m+3].change(controller_, (byte)hash.key_code["Left Windows"], true, false);
                        tickmain.apps[a].mt[m+4].change(controller_, key_, true, true);
                        tickmain.apps[a].mt[m+5].change(controller_, (byte)hash.key_code["Left Windows"], false, true);
                        tickmain.apps[a].mt[m+6].change(controller_, (byte)hash.key_code["SHIFT"], false, true);
                        tickmain.apps[a].mt[m+7].change(controller_, (byte)hash.key_code["CTRL"], false, true);
                        tickmain.apps[a].mt[m+8].change(controller_, (byte)hash.key_code["ALT"], false, true);
                        break;

                    default:
                        Array.Resize(ref tickmain.apps[a].mt, tickmain.apps[a].mt.Length + 1);
                        tickmain.apps[a].mt[m].change(controller_, key_, true, true);
                        break;
                }
                #endregion
                xconfig_SelectedIndexChanged(null, EventArgs.Empty);
            }
        }

        private void mt_new_(int i)
        {
            gridview.Rows.Add();
            xindex.Items.Add(i);

            gridview.Rows[i].Cells[0].Value = i;
            gridview.Rows[i].Cells[1].Value = xtype.SelectedItem;
            gridview.Rows[i].Cells[4].Value = xdown.CheckState;
            gridview.Rows[i].Cells[5].Value = xup.CheckState;
            gridview.Rows[i].Cells[6].Value = xrepeat.CheckState;

            if (xdown.CheckState == CheckState.Unchecked & xup.CheckState == CheckState.Unchecked)
            {
                gridview.Rows[i].Cells[4].Value = CheckState.Checked;
                gridview.Rows[i].Cells[5].Value = CheckState.Checked;
            }

            if (kradio.Checked)
            {
                gridview.Rows[i].Cells[2].Value = xkey.SelectedItem;
                gridview.Rows[i].Cells[3].Value = "";
            }
            else
            {
                gridview.Rows[i].Cells[2].Value = "";
                gridview.Rows[i].Cells[3].Value = xmouse.SelectedItem;
            }
        }

        //überprüfen
        private void mt_new_(int i, Microsoft.Xna.Framework.Input.Buttons controller_a, ushort key_a, CheckState down, CheckState up)
        {
            gridview.Rows.Add();
            xindex.Items.Add(i);

            gridview.Rows[i].Cells[0].Value = i;
            gridview.Rows[i].Cells[1].Value = controller_a;
            gridview.Rows[i].Cells[2].Value = key_a;
            gridview.Rows[i].Cells[3].Value = "";
            gridview.Rows[i].Cells[4].Value = down;
            gridview.Rows[i].Cells[5].Value = up;
            if (down == CheckState.Unchecked & up == CheckState.Unchecked)
            {
                gridview.Rows[i].Cells[4].Value = CheckState.Checked;
                gridview.Rows[i].Cells[5].Value = CheckState.Checked;
            }
        }

        private void mt_change_(int i)
        {
            gridview.Rows[i].Cells[0].Value = i;
            gridview.Rows[i].Cells[1].Value = xtype.SelectedItem;
            gridview.Rows[i].Cells[4].Value = xdown.CheckState;
            gridview.Rows[i].Cells[5].Value = xup.CheckState;
            gridview.Rows[i].Cells[6].Value = xrepeat.CheckState;
   
            if (kradio.Checked)
            {
                gridview.Rows[i].Cells[2].Value = xkey.SelectedItem;
                gridview.Rows[i].Cells[3].Value = "";
            }
            else
            {
                gridview.Rows[i].Cells[2].Value = "";
                gridview.Rows[i].Cells[3].Value = xmouse.SelectedItem;
            }
        }
    }
}
