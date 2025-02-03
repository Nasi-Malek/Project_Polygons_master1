using System;
using Spectre.Console;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Console;


namespace ClassLibrary.Models
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }


        public override double CalculateArea() => Width * Height;
        public override double CalculatePerimeter() => 2 * (Width + Height);
    }
    
}
