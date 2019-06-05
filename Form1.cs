using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int genRand = r.Next(1, 7);
            Console.WriteLine("Random Number =" + genRand);
            LbxInfo.Items.Add(genRand);


            if (genRand < 6 )
            {
                LbxInfo.Items.Add("It didnt rain!");

            }

            else
            {
                LbxInfo.Items.Add("You got wet! Game Over") ;
                BtnNextDay.Visible = false;
                


            }
     
        }
       
        private void BtnReload_Click(object sender, EventArgs e)
        {

        }

        private void Duck_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void LbxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GifUmbrella_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
