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
    public partial class FormTask4 : Form
    {
        public FormTask4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void FormTask4_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}
