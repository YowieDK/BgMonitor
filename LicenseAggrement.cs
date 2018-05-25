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
    public partial class LicenseAgrement : Form
    {
        private AppSettings appSetLicens = new AppSettings(); 
        public LicenseAgrement()
        {
            InitializeComponent();            
        }

        private void LicenseAgrement_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

                ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        
        void Licens_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (appSetLicens.LicenseAgrRead == false)
            {
                Globals.form.StartCloseDownTimer();
            }
        }

        private void Acceptpanel_Click(object sender, EventArgs e)
        {
            appSetLicens.LicenseAgrRead = true;
            appSetLicens.saveAllSettings();
            this.Close();
        }

        private void Declinpanel_Click(object sender, EventArgs e)
        {
            appSetLicens.LicenseAgrRead = false;
            appSetLicens.saveAllSettings();
            this.Close();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decline_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcceptPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
