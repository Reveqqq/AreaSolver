using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AreaSolver.Figures
{
    public class Triangle : Figure
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c)
        {
            if (!CheckTriangle(a, b, c))
                throw new Exception("There is no such triangle");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public bool IsRightAngledTriangle()
        {
            return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);

        }

        private bool CheckTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c) > a;
        }
    }
}
