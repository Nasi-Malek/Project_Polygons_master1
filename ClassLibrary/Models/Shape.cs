using System;
using Spectre.Console;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Console;


namespace ClassLibrary.Models
{
    public abstract class Shape
    {
        public required string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}

