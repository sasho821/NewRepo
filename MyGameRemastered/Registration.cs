using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGameRemastered
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            textBoxes_cleaner();

            textBox1.Text = "Введите название команды";
            textBox2.Text = "Введите название команды";
            textBox3.Text = "Введите название команды";
            textBox4.Text = "Введите название команды";
            textBox5.Text = "Введите название команды";
            textBox6.Text = "Введите название команды";
            textBox7.Text = "Введите название команды";
        }

        public static int num_teams = 1;
        public static string[] teams_names;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBoxes_cleaner();
            textBoxes_output((int)num_of_teams.Value);
            num_teams = (int)num_of_teams.Value;
        }

        private void textBoxes_cleaner()
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите название команды";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите название команды";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "Введите название команды";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "Введите название команды";
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = "Введите название команды";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "Введите название команды";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "Введите название команды";
            }

        }// erase all textboxes

        private void textBoxes_output(int n)
        {
            switch (n)
            {
                case 2:
                    textBox2.Visible = true;    
                    break;
                case 3:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    break;
                case 4:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    break;
                case 5:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    break;
                case 6:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    break;
                case 7:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    break;

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите название команды")
                textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите название команды")
                textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Введите название команды")
                textBox3.Text = "";
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Введите название команды")
                textBox5.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Введите название команды")
                textBox6.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "Введите название команды")
                textBox7.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Введите название команды")
                textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            teams_names = new string[] {textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
            textBox5.Text,textBox6.Text,textBox7.Text};

            Visible = false;
            Tasks table = new Tasks();
            table.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Program.random_queue = true;
            }
            else
            {
                Program.random_queue = false;
            }
        }
    }
}
