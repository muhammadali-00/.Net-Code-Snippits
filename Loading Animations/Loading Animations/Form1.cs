using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loading_Animations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loading.Width += 3;
            if (Loading.Width >= 599)
            {
                timer1.Start();
                Form2 f2 = new Form2();
                f2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hey Stop There");
            }
        }
    }
}
