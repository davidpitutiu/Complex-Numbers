using System;

namespace Complex_Numbers
{
    public class Complex
    {
        Random rnd = new Random();
        public double real { get; set; }
        public double imaginary { get; set; }
        public Complex()
        {
            this.real = rnd.Next(1, 20);
            this.imaginary = rnd.Next(1, 20);
        }
        public Complex(double a, double b)
        {
            this.real = a;
            this.imaginary = b;
        }
        public Complex(double a)
        {
            this.real = a;
            this.imaginary= rnd.Next(1, 20); ;
        }
        public static void Sum(double real1, double real2, double imaginary1, double imaginary2)
        {
            double sumr;
            double sumi;
            sumr = real1 + real2;
            sumi = imaginary1 + imaginary2;
            Console.WriteLine($"z1+z2={sumr}+{sumi}i");
        }
        public static void Substraction(double real1, double real2, double imaginary1, double imaginary2)
        {
            double subr;
            double subi;
            subr = real1 - real2;
            subi = imaginary1 - imaginary2;
            Console.WriteLine($"z1-z2={subr}-{subi}i");

        }
        public static void Multiply(double real1, double real2, double imaginary1, double imaginary2)
        {
            double multr;
            double multi;
            multr = real1 * real2 - imaginary1 * imaginary2;
            multi = real1 * imaginary2 + real2 * imaginary1;
            Console.WriteLine($"z1*z2={multr}+{multi}i");
        }
       public static void Power(string c,double real,double imaginary,double n)
        {
            if (n == 1)
            {
                Console.WriteLine($"{c}={real}+{imaginary}i");
            }
            else
            {
                double real1 = real;
                double imaginary1 = imaginary;
                for (int i = 0; i < n; i++)
                {
                    real = real * real1 - imaginary * imaginary1;
                    imaginary = real * imaginary1 + real1 * imaginary;
                }
                Console.WriteLine($"{c}^{n}={real}+{imaginary}i");
            }
        }
        public static void PolarForm(string c,double real,double imaginary)
        {
            double r;
            r = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
            r = Math.Abs(r);
            double t;
            t = Math.Atan(imaginary / real);
            Console.WriteLine($"The polar form of {c}=({r*Math.Cos(t)}+{r*Math.Sin(t)}i)");
        }
        public static void PolarFormPower(string c, double real, double imaginary,double n)
        {
            double r;
            r = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
            r = Math.Abs(r);
            double t;
            t = Math.Atan(imaginary / real);
            Console.WriteLine($"The polar form of {c}^{n}={Math.Pow(r, n)*Math.Cos(t*n)}+{Math.Pow(r, n)*Math.Sin(t*n)}i");

        }

    }
}