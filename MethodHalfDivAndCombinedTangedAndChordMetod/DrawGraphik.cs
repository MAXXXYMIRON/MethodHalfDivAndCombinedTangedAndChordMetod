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
        public static float Epsilon = 0.0001f;

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
                  y0 = Function(x0),
                  x = x0,
                  y = 0;

            for (int i = 0; i < Width; i++)
            {
                x += 0.05f;
                y = Function(x);

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
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);

            graph.DrawLine(myPen, Left + ((Width / 40) + a) * 20,
                      Height / 2 - Function(a) + Top,
                      Left + ((Width / 40) + b) * 20,
                      Height / 2 - Function(b) + Top);

            float Cnew = 0, Cold = 0;

            do
            {
                Cnew = (a * Function(b) - b * Function(a)) / (Function(b) - Function(a));
                if (Function(a) * Function(Cnew) < 0)
                {
                    Cold = b;
                    b = Cnew;
                }
                else if (Function(b) * Function(Cnew) < 0)
                {
                    Cold = a;
                    a = Cnew;
                }
                graph.DrawLine(myPen, Left + ((Width / 40) + a) * 20,
                Height / 2 - Function(a) + Top,
                Left + ((Width / 40) + b) * 20,
                Height / 2 - Function(b) + Top);

            }
            while (Math.Abs(Cold - Cnew) > Epsilon);

            return bitmap;
        }

        /// <summary>
        /// Метод косательных для данной функции
        /// </summary>
        /// <param name="bitmap">Координатная плоскость с начерченным графиком</param>
        /// <param name="a">Первая точка отрезка неопределенности</param>
        /// <param name="b">Вторая точка отрезка неопределенности</param>
        /// <returns>Полученный на вход парасетр bitmap с начерченными косательными</returns>
        public static Bitmap MethodTanget(Bitmap bitmap, float a, float b)
        { 
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);

            float Cold = 0, d = 0;

            do
            {
                if (Function(a) * TwoDeriativeFunction(a) > 0)
                {
                    Cold = a;
                    d = a - Function(a) / DeriativeFunction(a);
                    a = d;
                }
                else if (Function(b) * TwoDeriativeFunction(b) > 0)
                {
                    Cold = b;
                    d = b - Function(b) / DeriativeFunction(b);
                    b = d;
                }
                graph.DrawLine(myPen, Left + ((Width / 40) + Cold) * 20,
                Height / 2 - Function(Cold) + Top,
                Left + ((Width / 40) + d) * 20,
                Height / 2 + Top);
            }
            while (Math.Abs(Cold - d) > Epsilon);

            return bitmap;
        }

        public static float Function(float x0)
        {
            return (float)((3 * x0) + Math.Pow(5, x0) + 6);
            //return 4 * x0 * x0 * x0 - 5 * x0 * x0 - 2 * x0 + 2;
        }

        public static float DeriativeFunction(float x0)
        {
            return (float)(Math.Pow(5, x0) * Math.Log(5) + 3);
            //return (float)(12 * x0 * x0 - 10 * x0 - 2);

        }

        public static float TwoDeriativeFunction(float x0)
        {
            return (float)(Math.Pow(5, x0) * Math.Pow(Math.Log(5), 2));
            //return (float)(24 * x0 - 10);
        }
    }
}