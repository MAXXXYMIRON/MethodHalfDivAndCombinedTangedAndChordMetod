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
        /// <param name="a">Первая точка отрезка неопределенности, вернет кол-во итераций</param>
        /// <param name="b">Вторая точка отрезка неопределенности, вернет приближенное решение уравнения</param>
        /// <returns>Полученный на вход парасетр bitmap с начерченными хордами</returns>
        public static Bitmap MethodChord(Bitmap bitmap, ref float a, ref float b)
        {
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);

            graph.DrawLine(myPen, Left + ((Width / 40) + a) * 20,
                      Height / 2 - Function(a) + Top,
                      Left + ((Width / 40) + b) * 20,
                      Height / 2 - Function(b) + Top);

            float Cnew = 0, Cold = 0;
            ushort iter = 1;

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
                else return bitmap;

                graph.DrawLine(myPen, Left + ((Width / 40) + a) * 20,
                Height / 2 - Function(a) + Top,
                Left + ((Width / 40) + b) * 20,
                Height / 2 - Function(b) + Top);

                iter++;
            }
            while (Math.Abs(Cold - Cnew) > Epsilon);

            a = iter;
            b = Cnew;

            return bitmap;
        }

        /// <summary>
        /// Метод простых итераций для данной функции
        /// </summary>
        /// <param name="a">Начальная точка отрезка неопределенности, вернет кол-во итераций</param>
        /// <param name="b">Любая точка отрезка неопределенности, вернет приближенное решение уравнения</param>
        public static void MethodSimpleIteration(ref float a, ref float b)
        {
            float Xold = a, Xnew = FunctionH(Xold);
            ushort iter = 1;

            while(Math.Abs(Xnew - Xold) > Epsilon)
            {
                Xold = Xnew;
                Xnew = FunctionH(Xold);
                iter++;
            }

            a = iter;
            b = Xnew;
        }

        /// <summary>
        /// Метод косательных для данной функции
        /// </summary>
        /// <param name="bitmap">Координатная плоскость с начерченным графиком</param>
        /// <param name="a">Первая точка отрезка неопределенности, вернет кол-во итераций</param>
        /// <param name="b">Вторая точка отрезка неопределенности, вернет приближенное решение уравнения</param>
        /// <returns>Полученный на вход парасетр bitmap с начерченными косательными</returns>
        public static Bitmap MethodTanget(Bitmap bitmap, ref float a, ref float b)
        { 
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);

            float Cold = 0, d = 0;
            ushort iter = 0;

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

                iter++;
            }
            while (Math.Abs(Cold - d) > Epsilon);

            a = iter;
            b = d;

            return bitmap;
        }

        /// <summary>
        /// Комбинированный метод хорд и косательных
        /// </summary>
        /// <param name="bitmap">Координатная плоскость с начерченным графиком</param>
        /// <param name="a">Первая точка отрезка неопределенности, вернет кол-во итераций</param>
        /// <param name="b">Вторая точка отрезка неопределенности, вернет приближенное решение уравнения</param>
        /// <returns>Полученный на вход парасетр bitmap с начерченными косательными</returns>
        public static Bitmap MethodCombined(Bitmap bitmap, ref float a, ref float b)
        {
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);
            float c = 0, d = 0, Cold = 0, Dold = 0;
            ushort iter = 0;

            if (Function(a) * TwoDeriativeFunction(a) > 0)
            {
                Cold = a;
                Dold = a;
            }

            else if (Function(b) * TwoDeriativeFunction(b) > 0)
            {
                Cold = b;
                Dold = b;
            }


            while (Math.Abs(b - a) > 2 * Epsilon)
            {
                c = (a * Function(b) - b * Function(a)) / (Function(b) - Function(a));

                if (Function(a) * TwoDeriativeFunction(a) > 0)
                {
                    Dold = a;
                    d = a - Function(a) / DeriativeFunction(a);
                    a = d;
                    b = c;
                }
                else if(Function(b) * TwoDeriativeFunction(b) > 0)
                {
                    Dold = b;
                    d = b - Function(b) / DeriativeFunction(b);
                    b = d;
                    a = c;
                }

                //Построеие хорд
                graph.DrawLine(myPen, Left + ((Width / 40) + Dold) * 20,
                Height / 2 - Function(Dold) + Top,
                Left + ((Width / 40) + c) * 20,
                Height / 2 - Function(c) + Top);

                //Построение косательной
                graph.DrawLine(myPen, Left + ((Width / 40) + Dold) * 20,
                Height / 2 - Function(Dold) + Top,
                Left + ((Width / 40) + d) * 20,
                Height / 2 + Top);

                iter++;
            }

            b = a;
            a = iter;


            return bitmap;
        }

        /// <summary>
        /// Метод половинного деления
        /// </summary>
        /// <param name="bitmap">Координатная плоскость с начерченным графиком</param>
        /// <param name="a">Первая точка отрезка неопределенности, вернет кол-во итераций</param>
        /// <param name="b">Вторая точка отрезка неопределенности, вернет приближенное решение уравнения</param>
        /// <returns>Полученный на вход парасетр bitmap с начерченными косательными</returns>
        public static Bitmap MethodHalfDiv(Bitmap bitmap, ref float a, ref float b)
        {
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 0.5f);
            float c = 0;
            ushort iter = 0;

            while (Math.Abs(b - a) >  2 * Epsilon)
            {
                c = (a + b) / 2;

                if(Function(a) * Function(c) < 0)
                {
                    b = c;
                }
                else if(Function(b) * Function(c) < 0)
                {
                    a = c;
                }
                graph.DrawLine(myPen, Left + ((Width / 40) + c) * 20,
                Height / 2 - Function(c) - 4 + Top,
                Left + ((Width / 40) + c) * 20,
                Height / 2 - Function(c) + 4 + Top);

                iter++;
            }

            b = c;
            a = iter;

            return bitmap;
        }

        public static float Function(float x0)
        {
            return 1 - x0 - (x0 * x0) / 5;
            //return (float)((3 * x0) + Math.Pow(5, x0) + 6);
            //return 4 * x0 * x0 * x0 - 5 * x0 * x0 - 2 * x0 + 2;
        }

        public static float DeriativeFunction(float x0)
        {
            return -2 * (x0 / 5) -1;
            //return (float)(Math.Pow(5, x0) * Math.Log(5) + 3);
            //return (float)(12 * x0 * x0 - 10 * x0 - 2);
        }

        public static float TwoDeriativeFunction(float x0)
        {
            return -0.4f;
            //return (float)(Math.Pow(5, x0) * Math.Pow(Math.Log(5), 2));
            //return (float)(24 * x0 - 10);
        }

        public static float FunctionH(float x0)
        {
            return 1 - (x0 * x0) / 5;
        }
    }
}