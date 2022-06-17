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
    public partial class teach_quest : Form
    {
        public teach_quest()
        {
            InitializeComponent();
            label2.Text = "Осталось " + time + " секунд";
            task_timer.Enabled = true;
            task_timer.Start();
        }

        int time = 60;
        public int right_answer, q_price;

        private void button2_Click(object sender, EventArgs e)
        {
            Program.teams_scores[Program.queqe] += q_price;
            Program.queqe++;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            task_timer.Stop();
            label2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.teams_scores[Program.queqe] -= q_price;
            Program.queqe++;
            Close();
        }

        private void task_timer_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = "Осталось " + time + " секунд";
            if (time == 0)
            {
                task_timer.Stop();
                Program.teams_scores[Program.queqe] -= q_price;
                MessageBox.Show("Время вышло");
                Program.queqe++;
            }
        }
    }
}
