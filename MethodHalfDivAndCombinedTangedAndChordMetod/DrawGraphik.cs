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
            Pen myPen = new Pen(Color.Black, 1);

            for (int i = Top; i <= Height + Top; i += Height / 20)
            {
                graph.DrawLine(myPen, Left, i, Width + Left, i);
            }
            for (int i = Left; i <= Width + Left; i += Width / 20)
            {
                graph.DrawLine(myPen, i, Top, i, Height + Top);
            }

            myPen.Width = 2;
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
        public static Bitmap Graphix(ushort Top, ushort Left, ushort Height, ushort Width)
        {
            Bitmap bitmap = new Bitmap(Width + Left, Height + Top);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen myPen = new Pen(Color.Black, 1);


            return bitmap;
        }
    }
}
