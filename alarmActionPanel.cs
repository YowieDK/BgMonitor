using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BgLevelApp
{
    public partial class alarmActionPanel : Form
    {
        

        public alarmActionPanel()
        {
            InitializeComponent();
        }
              

        private void closeSnoozePanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Snooze5min_Click(object sender, EventArgs e)
        {
            Globals.form.SnoozeAlarm(5);
            this.Close();
        }

        private void Snooze10min_Click(object sender, EventArgs e)
        {
            Globals.form.SnoozeAlarm(10);
            this.Close();
        }

        private void Snooze15min_Click(object sender, EventArgs e)
        {
            Globals.form.SnoozeAlarm(15);
            this.Close();
        }

        private void Snooze20min_Click(object sender, EventArgs e)
        {
            Globals.form.SnoozeAlarm(20);
            this.Close();
        }

        private void Snooze30min_Click(object sender, EventArgs e)
        {
            Globals.form.SnoozeAlarm(30);
            this.Close();
        }

        private void Snooze60min_Click(object sender, EventArgs e)
        {
            Globals.form.SnoozeAlarm(60);
            this.Close();
        }

        private void Snooze120min_Click(object sender, EventArgs e)
        {
            Globals.form.SnoozeAlarm(120);
            this.Close();
        }

        private void KillTheAlarm_Click(object sender, EventArgs e)
        {
            Globals.form.KillAlarm();
            this.Close();
        }
    }
}
