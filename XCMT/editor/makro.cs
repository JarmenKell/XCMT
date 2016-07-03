using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XCMT.editor
{
    public partial class makro : Form
    {
        public makro()
        {
            InitializeComponent();
            mkey.KeyUp += new KeyEventHandler(mkey_KeyUp);

            #region mkey
            for (byte i = 0; i < helper.hash.key_.Length; i++) mkey.Items.Add(helper.hash.key_[i]);

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
            #endregion

            #region xtype.Items
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.A);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.B);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.Back);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.BigButton);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadDown);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadLeft);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadRight);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.DPadUp);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftShoulder);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftStick);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickDown);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickLeft);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickRight);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftThumbstickUp);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.LeftTrigger);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightShoulder);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightStick);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickDown);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickLeft);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickRight);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightThumbstickUp);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.RightTrigger);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.Start);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.X);
            mtype.Items.Add(Microsoft.Xna.Framework.Input.Buttons.Y);
            mtype.SelectedIndex = 3;
            #endregion

            toolTip1.SetToolTip(malt, "Die allgemeine Alt Taste");
            toolTip1.SetToolTip(mstrg, "Die allgeime Strg/Ctrl Taste");
            toolTip1.SetToolTip(mshift, "Die allgemeine Umschalt/Shift Taste");
            toolTip1.SetToolTip(mwin, "Die Linke Windows Taste");
            toolTip1.SetToolTip(mtype, "Stick/Trigger/Button auf den reagiert werden soll");
            toolTip1.SetToolTip(mkey, "zugeordnete Taste");
        }

        void mkey_KeyUp(object sender, KeyEventArgs e)
        {
            mkey.SelectedItem = helper.hash.code_key[(byte)e.KeyCode];
        }

        private void insert_Click(object sender, EventArgs e)
        {
            appedit.modifier = 0;
            if (malt.Checked) appedit.modifier += 1;
            if (mstrg.Checked) appedit.modifier += 2;
            if (mshift.Checked) appedit.modifier += 4;
            if (mwin.Checked) appedit.modifier += 8;

            appedit.controller_ = (Microsoft.Xna.Framework.Input.Buttons)mtype.SelectedItem;
            appedit.key_ = (byte)helper.hash.key_code[mkey.SelectedItem];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
