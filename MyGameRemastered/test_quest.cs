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
    public partial class test_quest : Form
    {
        public test_quest()
        {
            InitializeComponent();
            label2.Text = "Осталось " + time + " секунд";
            timer_quest.Enabled = true;
            timer_quest.Start();
        }

        public int right_answer, answer_price;
        
        private int answer = 0,time = 60;

        private void checker()
        {
            if (answer == right_answer)
            {
                Program.teams_scores[Program.queqe] += answer_price;
                MessageBox.Show("Верно");
                Program.queqe++;
                Tasks.steps++;
                Close();

            }
            else
            {
                Program.teams_scores[Program.queqe] -= answer_price;
                MessageBox.Show("Неверно");
                Program.queqe++;
                Tasks.steps++;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answer = 1;
            checker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer = 2;
            checker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answer = 3;
            checker();
        }

        private void timer_quest_Tick(object sender, EventArgs e)
        {
            label2.Text = "Осталось " + time + " секунд";
            time--;
            if (time == 0)
            {
                MessageBox.Show("Время вышло");
                Program.teams_scores[Program.queqe] -= answer_price;
                Program.queqe++;
                timer_quest.Stop();
                Tasks.steps++;
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer = 4;
            checker();
        }
    }
}
