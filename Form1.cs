using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRITGAME
{
    public partial class Form1 : Form
    {

        Boolean mLeft = false, mRight = false;

        public Form1()
        {
            InitializeComponent();


            //??????????????????????????????????????
            rek.Image = BRITGAME.Properties.Resources.pixsai;

            check.Enabled = true;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                mLeft = true;
            }

            if (e.KeyCode == Keys.A)
            {
                mRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                mLeft = false;
            }

            if (e.KeyCode == Keys.A)
            {
                mRight = false;
            }
        }

        private void check_Tick(object sender, EventArgs e)
        {
            if (mLeft)
            {
                rek.Left += 5;
            }

            if (mRight)
            {
                rek.Left -= 5;
            }
        }
    }
}
