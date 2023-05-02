using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors.Forms
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        public static int userChoice;

        private void button_rock_Click(object sender, EventArgs e)
        {
            userChoice = 1;
            form_game form = new form_game();
            form.Show();
            this.Hide();
        }

        private void button_paper_Click(object sender, EventArgs e)
        {
            userChoice = 2;
            form_game form = new form_game();
            form.Show();
            this.Hide();
        }

        private void button_scissors_Click(object sender, EventArgs e)
        {
            userChoice = 3;
            form_game form = new form_game();
            form.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
