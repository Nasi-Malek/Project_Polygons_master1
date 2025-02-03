using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Rhombus : Shape
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }
        public double Side { get; set; }


        public Rhombus(string name, double diagonal1, double diagonal2, double side) : base(name)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
            Side = side;
        }

        public override double CalculateArea() => 0.5 * Diagonal1 * Diagonal2;
        public override double CalculatePerimeter() => 4 * Side;
    }
    
}