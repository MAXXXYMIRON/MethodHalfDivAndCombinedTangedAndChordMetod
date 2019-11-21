using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodHalfDivAndCombinedTangedAndChordMetod
{
    public partial class DrawGrafix : Form
    {
        public DrawGrafix()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = DrawGraphik.CombienMethodChordAndTanged(40, 15, 400, 400);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            Close.Text = "X";
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.Text = "";
        }
    }
}
