using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaSolver.Figures
{
    public class Circle : Figure
    {
        double r;

        public Circle(double r)
        {
            if (r < 0)
                throw new Exception("Radius cannot be negative");

            this.r = r;
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }

        public override double Perimeter()
        {
            return Math.PI * r * 2;
        }
    }
}
