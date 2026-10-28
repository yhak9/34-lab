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
    public partial class FormTask2 : Form
    {
        public FormTask2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);


            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void FormTask2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
