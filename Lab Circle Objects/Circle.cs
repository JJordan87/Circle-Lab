using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Circle_Objects
{
    internal class Circle
    {
        public double Radius { get; set; }
        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public double CalculateCircumference()
        {

            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
             string formattedCircumference = FormatNumber(CalculateCircumference());
             return formattedCircumference;
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public string CalculateFormattedArea(double area)
        {
            string areaFormatted = FormatNumber(CalculateArea());
            return areaFormatted;
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
