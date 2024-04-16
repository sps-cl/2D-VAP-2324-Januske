using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ComplexNumber
    {
        public double Real;
        public double Imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public void Add(ComplexNumber other)
        {
            Real += other.Real;
            Imaginary += other.Imaginary;
        }

        public void Subtract(ComplexNumber other)
        {
            Real -= other.Real;
            Imaginary -= other.Imaginary;
        }

        
    }

}
