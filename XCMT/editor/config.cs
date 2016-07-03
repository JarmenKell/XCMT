using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using XCMT.Code;
using XCMT.helper;

namespace XCMT.editor
{
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();

            String title = XCMT.helper.wrapper.GetActiveWindowTitle();
            byte confs = 0;
            byte[] index = new byte[tickmain.apps.Length - 1];

            for (byte i = 0; i < tickmain.apps.Length; i++)
            {
                if (title.Contains(tickmain.apps[i].name))
                {
                    index[confs] = i;
                    confs++;
                }
            }

            switch(confs)
            {
                #region case 0
                case 0:
                    ccontrol.Height = tickmain.apps[0].mt.Length * 13;
                    cmousekey.Height = tickmain.apps[0].mt.Length * 13;
                    cdownup.Height = tickmain.apps[0].mt.Length * 13;
                    crepeat.Height = tickmain.apps[0].mt.Length * 13;

                    for (byte i = 0; i < tickmain.apps[0].mt.Length; i++)
                    {
                        ccontrol.Text += tickmain.apps[0].mt[i].button.ToString() + "\r\n";
                    
                        if (tickmain.apps[0].mt[i].mouse == "") cmousekey.Text += hash.code_key[tickmain.apps[0].mt[i].key] + "\r\n";
                        else cmousekey.Text += tickmain.apps[0].mt[i].mouse + "\r\n";

                        if (tickmain.apps[0].mt[i].press & !tickmain.apps[0].mt[i].release) cdownup.Text += "DOWN\r\n";
                        else if (!tickmain.apps[0].mt[i].press & tickmain.apps[0].mt[i].release) cdownup.Text += "UP\r\n";
                        else cdownup.Text += "DOWN & UP\r\n";

                        if (tickmain.apps[0].mt[i].repeat) crepeat.Text += "Repeat\r\n";
                        else crepeat.Text += "\r\n";
                    }
                    break;
                #endregion

                #region case 1
                case 1:
                    ccontrol.Height = tickmain.apps[index[0]].mt.Length * 13;
                    cmousekey.Height = tickmain.apps[index[0]].mt.Length * 13;
                    cdownup.Height = tickmain.apps[index[0]].mt.Length * 13;
                    crepeat.Height = tickmain.apps[0].mt.Length * 13;
                    cname.Text = tickmain.apps[index[0]].name;

                    for (byte i = 0; i < tickmain.apps[index[0]].mt.Length; i++)
                    {
                        ccontrol.Text += tickmain.apps[index[0]].mt[i].button.ToString() + "\r\n";

                        if (tickmain.apps[index[0]].mt[i].mouse == "") cmousekey.Text += hash.code_key[tickmain.apps[index[0]].mt[i].key] + "\r\n";
                        else cmousekey.Text += tickmain.apps[index[0]].mt[i].mouse + "\r\n";

                        if (tickmain.apps[index[0]].mt[i].press & !tickmain.apps[index[0]].mt[i].release) cdownup.Text += "DOWN\r\n";
                        else if (!tickmain.apps[index[0]].mt[i].press & tickmain.apps[index[0]].mt[i].release) cdownup.Text += "UP\r\n";
                        else cdownup.Text += "DOWN & UP\r\n";

                        if (tickmain.apps[index[0]].mt[i].repeat) crepeat.Text += "Repeat\r\n";
                        else crepeat.Text += "\r\n";

                    }
                    break;
                #endregion

                #region default
                default:
                    ccontrol.Height = -13;
                    cmousekey.Height = -13;
                    cdownup.Height = -13;
                    crepeat.Height = -13;
                    cname.Text = "";
                    for (byte j = 0; j < confs; j++)
                    {
                        ccontrol.Height += tickmain.apps[index[j]].mt.Length * 13;
                        cmousekey.Height += tickmain.apps[index[j]].mt.Length * 13;
                        cdownup.Height += tickmain.apps[index[j]].mt.Length * 13;
                        crepeat.Height = tickmain.apps[0].mt.Length * 13;
                        cname.Text += tickmain.apps[index[j]].name + " | ";

                        for (byte i = 0; i < tickmain.apps[index[j]].mt.Length; i++)
                        {
                            ccontrol.Text += tickmain.apps[index[j]].mt[i].button.ToString() + "\r\n";

                            if (tickmain.apps[index[j]].mt[i].mouse == "") cmousekey.Text += hash.code_key[tickmain.apps[index[j]].mt[i].key] + "\r\n";
                            else cmousekey.Text += tickmain.apps[index[j]].mt[i].mouse + "\r\n";

                            if (tickmain.apps[index[j]].mt[i].press & !tickmain.apps[index[j]].mt[i].release) cdownup.Text += "DOWN\r\n";
                            else if (!tickmain.apps[index[j]].mt[i].press & tickmain.apps[index[j]].mt[i].release) cdownup.Text += "UP\r\n";
                            else cdownup.Text += "DOWN & UP\r\n";

                            if (tickmain.apps[index[j]].mt[i].repeat) crepeat.Text += "Repeat\r\n";
                            else crepeat.Text += "\r\n";
                        }

                        ccontrol.Text += "\r\n";
                        cmousekey.Text += "\r\n";
                        cdownup.Text += "\r\n";

                        ccontrol.Height += 13;
                        cmousekey.Height += 13;
                        cdownup.Height += 13;
                    }
                    break;
                #endregion
            }
        }

        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }
    }
}
