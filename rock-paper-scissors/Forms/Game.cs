using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors.Forms
{
    public partial class form_game : Form
    {
        public form_game()
        {
            InitializeComponent();
        }

        int count = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            label_count.Text = count.ToString();

            if (count == 0)
            {
                label_count.Visible = false;
                timer1.Stop();

                // User Choice
                int userChoice = form_main.userChoice;

                string userImage = "";
                switch (userChoice)
                {
                    case 1:
                        userImage = "rock.png";
                        break;

                    case 2:
                        userImage = "paper.png";
                        break;

                    case 3:
                        userImage = "scissors.png";
                        break;
                }
                string userImageFilePath = Path.Combine(Application.StartupPath, userImage);
                picture_user_choice.Image = Image.FromFile(userImageFilePath);

                // PC Choice
                Random random = new Random();
                int pcChoice = random.Next(1, 4);

                string pcImage = "";
                switch (pcChoice)
                {
                    case 1:
                        pcImage = "rock.png";
                        break;

                    case 2:
                        pcImage = "paper.png";
                        break;

                    case 3:
                        pcImage = "scissors.png";
                        break;
                }
                string pcImageFilePath = Path.Combine(Application.StartupPath, pcImage);
                picture_pc_choice.Image = Image.FromFile(pcImageFilePath);

                // Check choices
                if (userChoice == 1 && pcChoice == 1)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "Draw!";
                    label_status.ForeColor = Color.White;
                }

                if (userChoice == 1 && pcChoice == 2)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "You Lose!";
                    label_status.ForeColor = Color.Red;
                }

                if (userChoice == 1 && pcChoice == 3)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "You Win!";
                    label_status.ForeColor = Color.Green;
                }

                if (userChoice == 2 && pcChoice == 1)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "You Win!";
                    label_status.ForeColor = Color.Green;
                }

                if (userChoice == 2 && pcChoice == 2)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "Draw!";
                    label_status.ForeColor = Color.White;
                }

                if (userChoice == 2 && pcChoice == 3)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "You Lose!";
                    label_status.ForeColor = Color.Red;
                }

                if (userChoice == 3 && pcChoice == 1)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "You Lose!";
                    label_status.ForeColor = Color.Red;
                }

                if (userChoice == 3 && pcChoice == 2)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "You Win!";
                    label_status.ForeColor = Color.Green;
                }

                if (userChoice == 3 && pcChoice == 3)
                {
                    label_status.Visible = true;
                    label_you_chose.Visible = true;
                    label_pc_chose.Visible = true;
                    button_play_again.Visible = true;

                    label_status.Text = "Draw!";
                    label_status.ForeColor = Color.White;
                }

            }
        }

        private void button_play_again_Click(object sender, EventArgs e)
        {
            form_main form = new form_main();
            form.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
