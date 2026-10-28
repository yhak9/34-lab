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
    public partial class FormTask1 : Form
    {
        int secretNumber;
        int attempts;
        private void StartGame()
        {
            Random rnd = new Random();
            secretNumber = rnd.Next(1, 101); 
            attempts = 0;

            textBox1.Clear(); 
            label2.Text = ""; 
            label4.Text = "0"; 
            label5.Text = ""; 

            textBox1.Enabled = true; 
            button1.Enabled = true;  
        }
        public FormTask1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userNumber;
            
            if (!int.TryParse(textBox1.Text, out userNumber))
            {
                MessageBox.Show("Введите число!", "Ошибка");
                return;
            }

            attempts++;
            label4.Text = attempts.ToString();

            
            if (userNumber < secretNumber)
            {
                label2.Text = "число больше!";
            }
            else if (userNumber > secretNumber)
            {
                label2.Text = "число меньше!";
            }
            else
            {
                label5.Text = "ВЫ УГАДАЛИ!";
                label2.Text = ""; 
                textBox1.Enabled = false; 
                button1.Enabled = false;  
            }
        }

        private void FormTask1_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
