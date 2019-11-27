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
            BackgroundImage = DrawGraphik.Function(40, 15, 400, 400);

            MethChord.Enabled = true;
            MethTanget.Enabled = true;
            CombinedMeth.Enabled = true;
            MethHalfDiv.Enabled = true;
            MethSimpleIter.Enabled = true;
        }

        //Проверка полей с точками отрезка неопределённости
        private bool GetAandB()
        {
            if(A.Text != "" && B.Text != "") return true;

            MessageBox.Show("Прежде чем выбрать метод, укажите отрезок неопределенности");
            return false;            
        }

        //Закрытие формы
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            Close.Text = "X";
        }
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.Text = "";
        }

        private void MethChord_Click(object sender, EventArgs e)
        {
            if(GetAandB())
            {
                Result.Text = "f(x) = 0 ";
                NumberIteration.Text = "Итераций -  ?";

                float a = Convert.ToSingle(A.Text),
                    b = Convert.ToSingle(B.Text);
                BackgroundImage = DrawGraphik.MethodChord(DrawGraphik.Function(40, 15, 400, 400), ref a, ref b);

                Result.Text = Result.Text.Remove(2, 1);
                Result.Text = Result.Text.Insert(2, b.ToString());

                NumberIteration.Text = NumberIteration.Text.Remove(NumberIteration.Text.Length -1);
                NumberIteration.Text = NumberIteration.Text.Insert(NumberIteration.Text.Length - 1, a.ToString());
            }
        }

        private void MethTanget_Click(object sender, EventArgs e)
        {
            if (GetAandB())
            {
                Result.Text = "f(x) = 0 ";
                NumberIteration.Text = "Итераций -  ?";

                float a = Convert.ToSingle(A.Text), 
                    b = Convert.ToSingle(B.Text);
                BackgroundImage = DrawGraphik.MethodTanget(DrawGraphik.Function(40, 15, 400, 400), ref a, ref b);
                Result.Text = Result.Text.Remove(2, 1);
                Result.Text = Result.Text.Insert(2, b.ToString());

                NumberIteration.Text = NumberIteration.Text.Remove(NumberIteration.Text.Length - 1);
                NumberIteration.Text = NumberIteration.Text.Insert(NumberIteration.Text.Length - 1, a.ToString());
            }
        }
    }
}
