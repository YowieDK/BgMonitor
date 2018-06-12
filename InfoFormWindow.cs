using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BgLevelApp
{
    public partial class InfoFormWindow : Form
    {
        public InfoFormWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        // ********************** Make moveable Start ****************
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        void moveOnMouseDownOnSettings(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        // *****************  Make moveable End *******************

        private void InfoFormWindow_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //Add mouse down to components to make form draggeable
            this.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);
           /* nsConnectionGroupBox.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);
            alarmSettingsGroupBox.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);
            MiscGroupBox.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);*/
            
        }

        
    }
}
