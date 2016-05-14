using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labWork1;

namespace labwork1_1
{
    /// <summary>
    /// Класс ромб
    /// </summary>
    public class Rhombus : IFigure
    { 
        /// <summary>
        /// Первая диагональ ромба
        /// </summary>
        public double _d1; 

        /// <summary>
        /// Вторая диагональ ромба
        /// </summary>
        public double _d2;

        /// <summary>
        /// Координата фигуры по оси Х
        /// </summary>
        public int _x;
        /// <summary>
        /// Координата фигуры по оси Y
        /// </summary>
        public int _y;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        /// <summary>
        /// Первая диагональ
        /// </summary>
        public double D1
        {
            get { return _d1; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _d1 = value;
            }
        }
        /// <summary>
        /// Вторая диагональ
        /// </summary>
        public double D2
        {
            get { return _d2; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _d2 = value;

            }
        }

        public string Name
        {
            get
            {
                return "Ромб";
            }
        }

        /// <summary>
        /// Метод рассчёта площади ромба 
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double CalculationArea()
    {
        return ((_d1*_d2)/2);
    }

}
}
