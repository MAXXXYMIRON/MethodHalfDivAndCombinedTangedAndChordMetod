using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MethodHalfDivAndCombinedTangedAndChordMetod
{
    static class DrawGraphik
    {
        /// <summary>
        /// Метод отрисовки координатной оси
        /// </summary>
        /// <param name="Top">Расстояние сверху координатной плоскости от левого верхнего угла окна</param>
        /// <param name="Left">Расстояние слево координатной плоскости от левого верхнего угла окна</param>
        /// <param name="Height">Высота координатной плоскости</param>
        /// <param name="Width">Ширина координатной плоскости</param>
        public static Bitmap CoordinatePlane(ushort Top, ushort Left, ushort Height, ushort Width)
        {
            Bitmap bitmap = new Bitmap(Width + Left, Height + Top);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.DimGray, 0.1f);

            for (int i = Top; i <= Height + Top; i += Height / 20)
            {
                graph.DrawLine(myPen, Left, i, Width + Left, i);
            }
            for (int i = Left; i <= Width + Left; i += Width / 20)
            {
                graph.DrawLine(myPen, i, Top, i, Height + Top);
            }

            myPen.Color = Color.Black;
            graph.DrawLine(myPen, (Width / 2) + Left, Top, (Width / 2) + Left, Height + Top);
            graph.DrawLine(myPen, Left, (Height / 2) + Top, Width + Left, (Height / 2) + Top);

            return bitmap;
        }

        /// <summary>
        /// Метод отрисовки функции
        /// </summary>
        /// <param name="Top">Расстояние сверху координатной плоскости от левого верхнего угла окна</param>
        /// <param name="Left">Расстояние слево координатной плоскости от левого верхнего угла окна</param>
        /// <param name="Height">Высота координатной плоскости</param>
        /// <param name="Width">Ширина координатной плоскости</param>
        public static Bitmap CombienMethodChordAndTanged(ushort Top, ushort Left, ushort Height, ushort Width)
        {
            CoordinatePlane(Top, Left, Height, Width);

            Bitmap bitmap = CoordinatePlane(Top, Left, Height, Width); 
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);

            float x0 = (Width / -40),
                  y0 = Equation(x0),
                  x = x0,
                  y = 0;

            for (int i = 0; i < Width; i++)
            {
                x += 0.05f;
                y = Equation(x);

                graph.DrawLine(myPen, Left + ((Width / 40) + x0) * 20, 
                                      Height / 2 - y0 + Top, 
                                      Left + ((Width / 40) + x) * 20, 
                                      Height / 2 - y + Top);

                x0 = x;
                y0 = y;
            }

            return bitmap;
        }

        public static float Equation(float x0)
        {
            return (float)((3 * x0) + Math.Pow(5, x0) + 6);
            //return 4 * x0 * x0 * x0 - 5 * x0 * x0 - 2 * x0 + 2;
        }
    }
}