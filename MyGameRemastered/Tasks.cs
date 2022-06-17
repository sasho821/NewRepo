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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            score_cleaner();
            score_buttons();
            if (Program.random_queue == true)
            {
                Random rnd = new Random();
                Program.queqe = rnd.Next(1, Registration.num_teams);
            }
        }

        
        static public int steps = 0;
        private int num_of_steps = 3; //количество заданий
        public string team1,team2,team3,team4,team5,team6,team7;
        
        

        public void beginner_names()
        {
            team1 = label6.Text;
            team2 = label7.Text;
            team3 = label8.Text;
            team4 = label9.Text;
            team5 = label10.Text;
            team6 = label11.Text;
            team7 = label12.Text;
        }

        public void score_buttons()
        {
            Button[] butp = { btnp1, btnp2, btnp3, btnp4, btnp5, btnp6, btnp7};
            Button[] butm = { btnm1, btnm2, btnm3, btnm4, btnm5, btnm6, btnm7 };

            for (int i = 0; i < Registration.num_teams; i++)
            {
                butp[i].Visible = true;
                butm[i].Visible = true;
            }
        }

        //string[] begin_tn;

        public void score_cleaner()
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            Label[] teams = { label6, label7, label8, label9, label10,
            label11, label12};

            for (int i = 0; i < Registration.num_teams; i++)
            {
                teams[i].ForeColor = Color.Black;
            }
            


            for(int i = 0; i < Registration.num_teams; i++)
            {
                teams[i].Text = Registration.teams_names[i];
            }

            beginner_names();

            for (int i = 0; i < Registration.num_teams; i++)
            {
                teams[i].Text = Registration.teams_names[i] + " " +  Program.teams_scores[i];
                teams[i].Visible = true;
            }

            teams[Program.queqe].ForeColor = Color.Red;
            
        }

        private void ender()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_quest q11 = new test_quest();

            q11.right_answer = 1; // Правильный вариант ответа
            q11.answer_price = 10;
            q11.label1.Text = "В каком году было образовано ШОС?"; /*
            Текст вапроса*/

            q11.button1.Text = "2001";
            q11.button2.Text = "2003";
            q11.button3.Text = "1999";
            q11.button4.Text = "1989";

            q11.Show();
            //steps++;
            button1.Visible = false;
        }

        public void game_over()
        {
            int max = Program.teams_scores[0], n_max = 0;
            string[] teams = {team1, team2, team3,team4,team5,team6,team7};

            for (int i = 0; i < Registration.num_teams; i++)
            {
                if (max < Program.teams_scores[i])
                {
                    max = Program.teams_scores[i];
                    n_max = i;
                }
            }
            timer1.Stop();
            MessageBox.Show("Поздравляю " + teams[n_max] + " Вы победили!!!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.queqe == Registration.num_teams)
            {
                Program.queqe = 0;
            }
            if (steps == num_of_steps)
            {
                game_over();
            }
            score_cleaner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test_quest q12 = new test_quest();

            q12.right_answer = 1; // Правильный вариант ответа
            q12.answer_price = 20;
            q12.label1.Text = "Кто президент РФ?"; /*
            Текст вапроса*/

            q12.button1.Text = "Путин";
            q12.button2.Text = "Байден";
            q12.button3.Text = "Зеленский";
            q12.button4.Text = "Лукашенко";

            q12.Show();
            //steps++;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test_quest q13 = new test_quest();

            q13.right_answer = 3; // Правильный вариант ответа
            q13.answer_price = 30;
            q13.label1.Text = "Кто проживает на дне океана?"; /*
            Текст вапроса*/

            q13.button1.Text = "Тедди";
            q13.button2.Text = "Винии Пух";
            q13.button3.Text = "Спанч Боб";
            q13.button4.Text = "Некоглай";

            q13.Show();
            //steps++;
            button3.Visible = false;
        }

        private void Tasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Program.teams_scores[0] += 10;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnm1_Click(object sender, EventArgs e)
        {
            Program.teams_scores[0] -= 10;
        }

        private void btnp2_Click(object sender, EventArgs e)
        {
            Program.teams_scores[1] += 10;
        }

        private void btnm2_Click(object sender, EventArgs e)
        {
            Program.teams_scores[1] -= 10;
        }

        private void btnp3_Click(object sender, EventArgs e)
        {
            Program.teams_scores[2] += 10;
        }

        private void btnm3_Click(object sender, EventArgs e)
        {
            Program.teams_scores[2] -= 10;
        }

        private void btnp4_Click(object sender, EventArgs e)
        {
            Program.teams_scores[3] += 10;
        }

        private void btnm4_Click(object sender, EventArgs e)
        {
            Program.teams_scores[3] -= 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teach_quest q14 = new teach_quest();
            q14.label1.Text = "Перечислите все региональные финансовые организации";

            q14.label3.Text = "ШОС, СНГ, ЕС, ВТО, ЮСМКА";

            q14.q_price = 40;

            q14.Show();

            button5.Visible = false;
        }

        private void btnp5_Click(object sender, EventArgs e)
        {
            Program.teams_scores[4] += 10;
        }

        private void btnm5_Click(object sender, EventArgs e)
        {
            Program.teams_scores[4] -= 10;
        }

        private void btnp6_Click(object sender, EventArgs e)
        {
            Program.teams_scores[5] += 10;
        }

        private void btnm6_Click(object sender, EventArgs e)
        {
            Program.teams_scores[5] -= 10;
        }

        private void btnp7_Click(object sender, EventArgs e)
        {
            Program.teams_scores[6] += 10;
        }

        private void btnm7_Click(object sender, EventArgs e)
        {
            Program.teams_scores[6] -= 10;
        }
    }
}
