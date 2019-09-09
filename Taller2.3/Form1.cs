using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Purple;

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }
    }
}
