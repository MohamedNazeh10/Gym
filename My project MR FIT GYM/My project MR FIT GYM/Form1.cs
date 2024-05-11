using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project_MR_FIT_GYM
{
    public partial class Form1 : Form
    {
        string User_Name = "Admin";
        string User_Pass = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void LOG_button_Click(object sender, EventArgs e)
        {
            if ((N_textBox.Text == User_Name) && (P_textBox.Text == User_Pass))
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("invalid user name or password");
            }

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
