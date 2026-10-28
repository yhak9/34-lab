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
    public partial class FormTask8 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;

        public FormTask8()
        {
            InitializeComponent();
        }

        
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        
        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            result = double.Parse(textBox1.Text);
            operation = btn.Text;
            isOperationPerformed = true;
        }

       
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double secondNumber = double.Parse(textBox1.Text);
                switch (operation)
                {
                    case "+": textBox1.Text = (result + secondNumber).ToString(); break;
                    case "-": textBox1.Text = (result - secondNumber).ToString(); break;
                    case "*": textBox1.Text = (result * secondNumber).ToString(); break;
                    case "/":
                        if (secondNumber == 0)
                            textBox1.Text = "Ошибка (деление на 0)";
                        else
                            textBox1.Text = (result / secondNumber).ToString();
                        break;
                }
            }
            catch
            {
                textBox1.Text = "Ошибка";
            }
            isOperationPerformed = true;
        }

       
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
        }

       
        private void FormTask8_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}