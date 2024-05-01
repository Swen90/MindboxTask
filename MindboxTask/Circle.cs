using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            if (Validate(radius))
                Radius = radius;
        }

        public bool Validate(double r)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException($"Радиус со значением {r} не может быть меньше или равен нулю");
            
            return true;
        }

        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
        }
    }
}
