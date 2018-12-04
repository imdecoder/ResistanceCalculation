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
    public partial class FormMain : Form
    {
        public static ResourceManager res_man;
        public static CultureInfo cul;

        int mov, movX, movY;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            res_man = new ResourceManager("Resistance_Calculation.Languages.Res", typeof(FormMain).Assembly);
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

        private void picTR_Click(object sender, EventArgs e)
        {
            cul = CultureInfo.CreateSpecificCulture("tr");
            switchForm();
            //TR değil, Türkiye olmalı.
        }

        private void picEN_Click(object sender, EventArgs e)
        {
            cul = CultureInfo.CreateSpecificCulture("en");
            switchForm();
        }

        private void switchForm()
        {
            this.Hide();

            FormHome frmHome = new FormHome();
            frmHome.Show();
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
