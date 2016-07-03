using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace XCMT.Code
{

    public class trayform : Form
    {
        private NotifyIcon notifyIcon;
        private ContextMenu contextMenu;
        private MenuItem menuexit;
        private MenuItem menuminimize;
        private MenuItem menunormal;
        private MenuItem menuedit;
        private MenuItem menuset;
        private IContainer components;
        private editor.config conf;
        private Boolean conf_enable = true;
        private Boolean closetray = false;
        public static Boolean set_enable = true;
        public static Boolean edit_enable = true;
        

        [STAThread]
        static void Main() { Application.Run(new trayform()); }

        public static Label aktiv = new Label();
        private trayform()
        {
            test bla = new test();
            bla.Show();

            this.components = new Container();
            this.contextMenu = new ContextMenu();
            this.menuexit = new MenuItem();
            this.menuminimize = new MenuItem();
            this.menunormal = new MenuItem();
            this.menuedit = new MenuItem();
            this.menuset = new MenuItem();

            this.ShowInTaskbar = false;
            this.Location = new Point(Properties.Settings.Default.posx, Properties.Settings.Default.posy);
            this.StartPosition = FormStartPosition.Manual;
            this.ClientSize = new Size(Properties.Settings.Default.widh, Properties.Settings.Default.height);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;

            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { this.menuexit, this.menuminimize, this.menunormal, this.menuedit, this.menuset });
            this.contextMenu.Popup += new EventHandler(contextMenu_Popup);
            this.FormClosing += new FormClosingEventHandler(trayform_FormClosing);

            this.menuexit.Index = 4;
            this.menuexit.Text = "Beenden";
            this.menuexit.Click += new EventHandler(menuexit_Click);
            this.menuminimize.Index = 3;
            this.menuminimize.Text = "Minimieren";
            this.menuminimize.Click += new EventHandler(menuminimize_Click);
            this.menunormal.Index = 2;
            this.menunormal.Text = "Öffnen";
            this.menunormal.Click += new EventHandler(menunormal_Click);
            this.menuedit.Index = 1;
            this.menuedit.Text = "App Editor";
            this.menuedit.Click += new EventHandler(menuedit_Click);
            this.menuset.Index = 0;
            this.menuset.Text = "Einstellungen";
            this.menuset.Click += new EventHandler(menuset_Click);

            aktiv.Location = new Point(5, 5);
            aktiv.Text = "Programm wird gestartet und Einstellungen geladen";
            aktiv.Width = Properties.Settings.Default.widh - 10;
            aktiv.Height = Properties.Settings.Default.height - 10;
            this.Controls.Add(aktiv);

            this.Text = "XCMT";

            this.notifyIcon = new NotifyIcon(this.components);
            notifyIcon.Icon = new Icon("xbox.ico");
            notifyIcon.ContextMenu = this.contextMenu;
            notifyIcon.Text = "XCMT Tray";
            notifyIcon.Visible = true;

            notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            trayform.CheckForIllegalCrossThreadCalls = false;

            XCMT.helper.xdata.Deserialize();
            helper.hash.fill();
            XCMT.helper.wrapper.RegisterHotKey(this.Handle, 11111, Properties.Settings.Default.modifer, Properties.Settings.Default.hotkey);
            tickmain.uhr();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == helper.wrapper.WM_HOTKEY)
            {
                if (conf_enable == true)
                {
                    conf = new editor.config();
                    conf.Show();
                    conf_enable = false;
                }
                else
                {
                    conf.Close();
                    conf_enable = true;
                }
            }
        }

        void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        void contextMenu_Popup(object sender, EventArgs e)
        {
            menuset.Enabled = set_enable;
            menuedit.Enabled = edit_enable;
        }

        void menuset_Click(object sender, EventArgs e)
        {
            editor.settings set = new editor.settings();
            set.Show();
            set_enable = false;
        }
        
        void menuedit_Click(object sender, EventArgs e)
        {
            editor.appedit editor = new editor.appedit();
            editor.Show();
            edit_enable = false;
        }

        void menunormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        void menuminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void menuexit_Click(object Sender, EventArgs e)
        {
            closetray = true;
            this.Close();
        }

        void trayform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closetray == false & e.CloseReason != CloseReason.WindowsShutDown)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }
    }
}