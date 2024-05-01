using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask
{
    public class Triangle : Shape
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(string name, double a, double b, double c) : base(name) 
        { 
            if(Validate(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
        }

        public double Perimeter()
        {
            return (SideA + SideB + SideC) / 2;
        }

        public static bool Validate(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Ни одна из сторон не должна быть отрицательной или равна нулю");

            return  true;
        }

        public override double Square()
        {
            double p = Perimeter();
            return Math.Round(Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 3);
        }

        private static bool Pifagor(double a, double b, double c)
        {
            return Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2));
        }

        public bool IsRightTriangle()
        {
            return Pifagor(SideA, SideB, SideC) || Pifagor(SideB, SideA, SideC) || Pifagor(SideC, SideA, SideB);
        }
    }
}
