using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMenuPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
               button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           button1.BackColor = default(Color);
            button1.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = default(Color);
            button2.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = default(Color);
            button3.ForeColor = Color.White;

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = default(Color);
            button4.ForeColor = Color.White;
        }
    }
}
