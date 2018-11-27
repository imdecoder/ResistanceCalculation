using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace Resistance_Calculation
{
    public partial class FormHome : Form
    {
        private ResourceManager res_man = FormMain.res_man;
        private CultureInfo cul = FormMain.cul;

        int mov, movX, movY;

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblTitle.Text = res_man.GetString("Form_title", cul);
            lbl3Precious.Text = res_man.GetString("Precious_3", cul);
            lbl4Precious.Text = res_man.GetString("Precious_4", cul);
            lbl5Precious.Text = res_man.GetString("Precious_5", cul);
            lbl6Precious.Text = res_man.GetString("Precious_6", cul);
            lblHelp.Text = res_man.GetString("Help", cul);
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlSMD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hop!");
        }

        private void pnl3Precious_Click(object sender, EventArgs e)
        {

        }

        private void pn4Precious_Click(object sender, EventArgs e)
        {

        }

        private void pnl5Precious_Click(object sender, EventArgs e)
        {

        }

        private void pnl6Precious_Click(object sender, EventArgs e)
        {

        }

        private void pnlInfo_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
