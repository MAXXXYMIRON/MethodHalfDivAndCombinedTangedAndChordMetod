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
        private static ushort Top, Left, Height, Width;

        /// <summary>
        /// Метод отрисовки координатной оси
        /// </summary>
        /// <param name="top">Расстояние сверху координатной плоскости от левого верхнего угла окна</param>
        /// <param name="left">Расстояние слево координатной плоскости от левого верхнего угла окна</param>
        /// <param name="height">Высота координатной плоскости</param>
        /// <param name="width">Ширина координатной плоскости</param>
        public static Bitmap CoordinatePlane(ushort top, ushort left, ushort height, ushort width)
        {
            Top = top;
            Left = left;
            Height = height;
            Width = width;

            Bitmap bitmap = new Bitmap(width + left, height + top);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.DimGray, 0.1f);

            for (int i = top; i <= height + top; i += height / 20)
            {
                graph.DrawLine(myPen, left, i, width + left, i);
            }
            for (int i = left; i <= width + left; i += width / 20)
            {
                graph.DrawLine(myPen, i, top, i, height + top);
            }

            myPen.Color = Color.Black;
            graph.DrawLine(myPen, (width / 2) + left, top, (width / 2) + left, height + top);
            graph.DrawLine(myPen, left, (height / 2) + top, width + left, (height / 2) + top);

            return bitmap;
        }

        /// <summary>
        /// Метод отрисовки функции
        /// </summary>
        /// <param name="Top">Расстояние сверху координатной плоскости от левого верхнего угла окна</param>
        /// <param name="Left">Расстояние слево координатной плоскости от левого верхнего угла окна</param>
        /// <param name="Height">Высота координатной плоскости</param>
        /// <param name="Width">Ширина координатной плоскости</param>
        public static Bitmap Function(ushort top, ushort left, ushort height, ushort width)
        {
            CoordinatePlane(top, left, height, width);

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

        /// <summary>
        /// Метод хорд для данной функции
        /// </summary>
        /// <param name="bitmap">Координатная плоскость с начерченным графиком</param>
        /// <param name="a">Первая точка отрезка неопределенности, в котором хорда пересекется с Ох</param>
        /// <param name="b">Вторая точка отрезка неопределенности, в котором хорда пересекется с Ох</param>
        /// <returns>Полученный на вход парасетр bitmap с начерченными хордами</returns>
        public static Bitmap MethodChord(Bitmap bitmap, float a, float b)
        {
            float Epsilon = 0.0001f;

            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);

            graph.DrawLine(myPen, Left + ((Width / 40) + a) * 20,
                      Height / 2 - Equation(a) + Top,
                      Left + ((Width / 40) + b) * 20,
                      Height / 2 - Equation(b) + Top);

            float Cnew = 0, Cold = 0;

            do
            {
                Cnew = (a * Equation(b) - b * Equation(a)) / (Equation(b) - Equation(a));
                if (Equation(a) * Equation(Cnew) < 0)
                {
                    Cold = b;
                    b = Cnew;
                }
                else if (Equation(b) * Equation(Cnew) < 0)
                {
                    Cold = a;
                    a = Cnew;
                }
                graph.DrawLine(myPen, Left + ((Width / 40) + a) * 20,
                Height / 2 - Equation(a) + Top,
                Left + ((Width / 40) + b) * 20,
                Height / 2 - Equation(b) + Top);

            }
            while (Math.Abs(Cold - Cnew) > Epsilon);

            return bitmap;
        }

        public static float Equation(float x0)
        {
            return (float)((3 * x0) + Math.Pow(5, x0) + 6);
            //return 4 * x0 * x0 * x0 - 5 * x0 * x0 - 2 * x0 + 2;
        }
    }
}