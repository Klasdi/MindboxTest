using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest
{
    public class Triangle: Сalculation
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new Exception("Длина каждой стороны должна быть положительна");
            _a = a;
            _b = b;
            _c = c;
        }

        public bool IsRightTriangle()
        {
            double[] mas = {_a, _b, _c};
            Array.Sort(mas);
            return Math.Pow(mas[0],2) + Math.Pow(mas[1], 2) == Math.Pow(mas[2], 2); 
        }

        public double Square()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
