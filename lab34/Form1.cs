using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTask1 task1 = new FormTask1();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTask2 task2 = new FormTask2();
            task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTask3 task3 = new FormTask3();
            task3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTask4 task4 = new FormTask4();
            task4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTask5 task5 = new FormTask5();
            task5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormTask6 task6 = new FormTask6();
            task6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormTask8 task8 = new FormTask8();
            task8.Show();
        }
    }
}
