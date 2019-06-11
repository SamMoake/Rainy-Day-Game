using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        RandomNumb MyRandomNumber = new RandomNumb();
       // private SoundPlayer _soundplayer;

        public Form1()
        {
            InitializeComponent();

           
        }
        
        int count = 1;

        private void Fire_Click(object sender, EventArgs e)
        {
            MyRandomNumber.GetRNDNumber();
            Console.WriteLine("Random Number =" + MyRandomNumber.RNDNumber);

            count++;
            if (count == 8) 
            {
                MessageBox.Show("Congrats you have lasted a week");
                Application.Restart();
            }
            


            if (MyRandomNumber.RNDNumber < 4 )
            {
                LbxInfo.Items.Add("It didnt rain");
            }

            else
            {
                LbxInfo.Items.Add("You got wet! Game Over") ;
                BtnNextDay.Visible = false;
                pictureBox2.Visible = false;
                rain();
            }
     
        }
       


        private void Duck_Click(object sender, EventArgs e)
        {
            count++;
            if ()
            
            LbxInfo.Items.Add("You used the umbrella");
            BtnUmbrella.Visible = false;


        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        public static void rain()
        {
            //Plays rain sounds when lose
            SoundPlayer snPlayer = new SoundPlayer(Resource1.Rain);
            snPlayer.Play();

        }
    }
}
