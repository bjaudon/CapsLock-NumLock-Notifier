using System;
using System.Windows.Forms;

namespace CapsLock_NumLock_Notifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (IsKeyLocked(Keys.NumLock))
            {
                case true:
                    {
                        NumLockNotifyIcon.Icon = Properties.Resources.numlock_on;
                        NumLockNotifyIcon.Text = "NumLock: ON";
                        break;
                    }
                case false:
                    {
                        NumLockNotifyIcon.Icon = Properties.Resources.numlock_off;
                        NumLockNotifyIcon.Text = "NumLock: OFF";
                        break;
                    }
            }
                    switch (IsKeyLocked(Keys.CapsLock))
                    {
                        case true:
                            {
                                CapsLockNotifyIcon.Icon = Properties.Resources.capslock_on;
                                CapsLockNotifyIcon.Text = "CapsLock: ON";
                        break;
                            }
                        case false:
                            {
                                CapsLockNotifyIcon.Icon = Properties.Resources.capslock_off;
                                CapsLockNotifyIcon.Text = "CapsLock: OFF";
                        break;
                            }

                    }
        }

        private void CapsLockNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            SendKeys.Send("{CAPSLOCK}");
        }

        private void NumLockNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            SendKeys.Send("{NUMLOCK}");
        }

        private void toolStripMenuItemToggleCapsLock_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{CAPSLOCK}");
        }

        private void toolStripMenuItemQuit1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemToggleNumLock_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{NUMLOCK}");
        }

        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            Hide();
            Visible = false;
        }
    }
}
