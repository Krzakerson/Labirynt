using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLabirynt
{
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbRestart_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }
    }
}
