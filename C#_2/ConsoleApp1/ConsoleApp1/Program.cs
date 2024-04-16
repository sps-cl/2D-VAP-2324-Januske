using System;

namespace CMD_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the real part of first complex number:");
            double aReal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the imaginary part of first complex number:");
            double aImaginary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the real part of second complex number:");
            double bReal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the imaginary part of second complex number:");
            double bImaginary = double.Parse(Console.ReadLine());

            if (operation == '+') Console.WriteLine(new ComplexNumber(aReal, aImaginary) + new ComplexNumber(bReal, bImaginary));
            else if (operation == '-') Console.WriteLine(new ComplexNumber(aReal, aImaginary) - new ComplexNumber(bReal, bImaginary));
            else if (operation == '*') Console.WriteLine(new ComplexNumber(aReal, aImaginary) * new ComplexNumber(bReal, bImaginary));
            else if (operation == '/') Console.WriteLine(new ComplexNumber(aReal, aImaginary) / new ComplexNumber(bReal, bImaginary));
            else Console.WriteLine("Invalid operation");

            Console.ReadLine();
        }

        class ComplexNumber
        {
            double real;
            double imaginary;
            public ComplexNumber(double real, double imaginary)
            {
                this.real = real;
                this.imaginary = imaginary;
            }
            #region Methods
            public ComplexNumber Add(ComplexNumber other)
            {
                return new ComplexNumber(this.real + other.real, this.imaginary + other.imaginary);
            }
            public ComplexNumber Subtract(ComplexNumber other)
            {
                return new ComplexNumber(this.real - other.real, this.imaginary - other.imaginary);
            }
            public ComplexNumber Multiply(ComplexNumber other)
            {
                return new ComplexNumber(this.real * other.real - this.imaginary * other.imaginary, this.real * other.imaginary + this.imaginary * other.real);
            }
            public ComplexNumber Divide(ComplexNumber other)
            {
                double real = (this.real * other.real + this.imaginary * other.imaginary) / (other.real * other.real + other.imaginary * other.imaginary);
                double imaginary = (this.imaginary * other.real - this.real * other.imaginary) / (other.real * other.real + other.imaginary * other.imaginary);
                return new ComplexNumber(real, imaginary);
            }
            #endregion
            #region Overiding operators
            #region Addition
            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
            }
            public static ComplexNumber operator +(double a, ComplexNumber b)
            {
                return new ComplexNumber(b.real + a, b.imaginary + a);
            }
            public static ComplexNumber operator +(ComplexNumber b, double a)
            {
                return new ComplexNumber(b.real + a, b.imaginary + a);
            }
            #endregion
            #region Subtraction
            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary);
            }
            public static ComplexNumber operator -(double a, ComplexNumber b)
            {
                return new ComplexNumber(b.real - a, b.imaginary - a);
            }
            public static ComplexNumber operator -(ComplexNumber b, double a)
            {
                return new ComplexNumber(b.real - a, b.imaginary - a);
            }
            #endregion
            #region Multiplication
            public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
            {
                return new ComplexNumber(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + a.imaginary * b.real);
            }
            public static ComplexNumber operator *(double a, ComplexNumber b)
            {
                return new ComplexNumber(b.real * a, b.imaginary * a);
            }
            public static ComplexNumber operator *(ComplexNumber b, double a)
            {
                return new ComplexNumber(b.real * a, b.imaginary * a);
            }
            #endregion
            #region Division
            public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
            {
                double real = (a.real * b.real + a.imaginary * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary);
                double imaginary = (a.imaginary * b.real - a.real * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary);
                return new ComplexNumber(real, imaginary);
            }
            public static ComplexNumber operator /(double a, ComplexNumber b)
            {
                double real = (a * b.real) / (b.real * b.real + b.imaginary * b.imaginary);
                double imaginary = (-a * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary);
                return new ComplexNumber(real, imaginary);
            }
            public static ComplexNumber operator /(ComplexNumber b, double a)
            {
                return new ComplexNumber(b.real / a, b.imaginary / a);
            }
            #endregion

            #region Equality
            public static bool operator ==(ComplexNumber a, ComplexNumber b)
            {
                return a.real == b.real && a.imaginary == b.imaginary;
            }
            public static bool operator !=(ComplexNumber a, ComplexNumber b)
            {
                return a.real != b.real || a.imaginary != b.imaginary;
            }
            #endregion

            public override string ToString()
            {
                return $"{{real: {real}, imaginary: {imaginary}}}";
            }
            #endregion
        }
    }
}