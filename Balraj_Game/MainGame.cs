using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balraj_Game
{
    public partial class MainGame : Form
    {
        int frst, scnd, thrd;
        String better1 = "";
        int runer1 = 0;
        public MainGame()
        {
            InitializeComponent();
            frst = BalrajPunter.ist;
            scnd = BalrajPunter.scnd;
            thrd = BalrajPunter.thrd;
            blance1.Text = "" + frst;
            balance2.Text = "" + scnd;
            balance3.Text = "" + thrd;
            MessageBox.Show("first of all select the player and then the dog by clicking on the picture of those ");
        }

        public void resetPicture()
        {
            racer1.Enabled = true;
            racer2.Enabled = true;
            racer3.Enabled = true;
            racer4.Enabled = true;
            plr1.Enabled = true;
            plr2.Enabled = true;
            plr3.Enabled = true;
            betAmount.Value = 0;
            better1 = "";
            runer1 = 0;
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            if (!better1.Equals("") && runer1 > 0)
            {
                if (betAmount.Value <= 50 && betAmount.Value <= frst && better1.Equals("Raman") && betAmount.Value > 0) { Player1.Text = better1 + " choose Dog " + runer1 + " and " + betAmount.Value; raceBtn.Enabled = true; resetPicture(); }

                else if (betAmount.Value <= 50 && betAmount.Value <= scnd && better1.Equals("Aman") && betAmount.Value > 0) { Player2.Text = better1 + " choose Dog " + runer1 + " and " + betAmount.Value; raceBtn.Enabled = true; resetPicture(); }

                else if (betAmount.Value <= 50 && betAmount.Value <= thrd && better1.Equals("Sanjna") && betAmount.Value > 0) { Player3.Text = better1 + " choose Dog " + runer1 + " and " + betAmount.Value; raceBtn.Enabled = true; resetPicture(); }
                else { MessageBox.Show("Bet Amount Must be Greater then zero "); }
            }
            else
            {
                MessageBox.Show("you have to choose atleast one player and one dog to participate ");

            }
        }

        private void raceBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            betBtn.Enabled = false;
            raceBtn.Enabled = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            racer1.Left = 0;
            racer2.Left = 0;
            racer3.Left = 0;
            racer4.Left = 0;
            betAmount.Value = 0;
            resetPicture();
            Player1.Text = "Anny";
            Player2.Text = "Anu";
            Player3.Text = "Anjali";
            raceBtn.Enabled = true;
            betBtn.Enabled = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);//code for exit 
        }

        private void plr1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Budget is " + BalrajPunter.firstbetter(frst));
            plr1.Enabled = false;
            plr2.Enabled = false;
            plr3.Enabled = false;

            better1 = "Raman";
        }

        private void plr2_Click(object sender, EventArgs e)
        {
            better1 = "Aman";
            MessageBox.Show("Your Budget is " + BalrajPunter.scndbetter(scnd));
            plr1.Enabled = false;
            plr2.Enabled = false;
            plr3.Enabled = false;
        }

        private void racer1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog First is selected ");
            runer1 = 1;
            racer1.Enabled = false;
            racer2.Enabled = false;
            racer3.Enabled = false;
            racer4.Enabled = false;
        }

        private void racer2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog Second is selected ");
            runer1 = 2;
            racer1.Enabled = false;
            racer2.Enabled = false;
            racer3.Enabled = false;
            racer4.Enabled = false;
        }

        private void racer3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog thrd is selected ");
            runer1 = 3;
            racer1.Enabled = false;
            racer2.Enabled = false;
            racer3.Enabled = false;
            racer4.Enabled = false;
        }

        private void racer4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog Forth is selected ");
            runer1 = 4;
            racer1.Enabled = false;
            racer2.Enabled = false;
            racer3.Enabled = false;
            racer4.Enabled = false;
        }

        private void plr3_Click(object sender, EventArgs e)
        {
            better1 = "Sanjna";
            MessageBox.Show("Your Budget is " + BalrajPunter.thrdbetter(thrd));
            plr1.Enabled = false;
            plr2.Enabled = false;
            plr3.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            racer1.Left += BalrajGreyhound.move();
            racer2.Left += BalrajGreyhound.move();
            racer3.Left += BalrajGreyhound.move();
            racer4.Left += BalrajGreyhound.move();

            if (BalrajGreyhound.pause(racer1.Left) == 1)
            {
                timer1.Stop();
                MessageBox.Show("1st dog is winner ");
                // for setting the budget
                if (Player1.Text.ToString().Length > 10) { frst = Raman.winnner(Player1.Text.ToString(), frst, 1); }
                if (Player2.Text.ToString().Length > 10) { scnd = Aman.winnner(Player2.Text.ToString(), scnd, 1); }
                if (Player3.Text.ToString().Length > 10) { frst = Sanjna.winnner(Player3.Text.ToString(), thrd, 1); }
                Player1.Text = "Raman";
                Player2.Text = "Aman";
                Player3.Text = "Sanjna";
            }
            if (BalrajGreyhound.pause(racer2.Left) == 1)
            {
                timer1.Stop();
                MessageBox.Show("2nd dog is winner");
                // for setting the budget
                if (Player1.Text.ToString().Length > 10) { frst = Raman.winnner(Player1.Text.ToString(), frst, 2); }
                if (Player2.Text.ToString().Length > 10) { scnd = Aman.winnner(Player2.Text.ToString(), scnd, 2); }
                if (Player3.Text.ToString().Length > 10) { frst = Sanjna.winnner(Player3.Text.ToString(), thrd, 2); }
                Player1.Text = "Raman";
                Player2.Text = "Aman";
                Player3.Text = "Sanjna";
            }

            if (BalrajGreyhound.pause(racer3.Left) == 1)
            {
                timer1.Stop();
                MessageBox.Show("3rd dog is winner");
                // for setting the budget
                if (Player1.Text.ToString().Length > 10) { frst = Raman.winnner(Player1.Text.ToString(), frst, 3); }
                if (Player2.Text.ToString().Length > 10) { scnd = Aman.winnner(Player2.Text.ToString(), scnd, 3); }
                if (Player3.Text.ToString().Length > 10) { frst = Sanjna.winnner(Player3.Text.ToString(), thrd, 3); }
                Player1.Text = "Raman";
                Player2.Text = "Aman";
                Player3.Text = "Sanjna";
            }

            if (BalrajGreyhound.pause(racer4.Left) == 1)
            {
                timer1.Stop();
                MessageBox.Show("4th dog is winner");
                // for setting the budget
                if (Player1.Text.ToString().Length > 10) { frst = Raman.winnner(Player1.Text.ToString(), frst, 4); }
                if (Player2.Text.ToString().Length > 10) { scnd = Aman.winnner(Player2.Text.ToString(), scnd, 4); }
                if (Player3.Text.ToString().Length > 10) { frst = Sanjna.winnner(Player3.Text.ToString(), thrd, 4); }
                Player1.Text = "Raman";
                Player2.Text = "Aman";
                Player3.Text = "Sanjna";
            }
            blance1.Text = "" + frst;
            balance2.Text = "" + scnd;
            balance3.Text = "" + thrd;
        }
    }
}
