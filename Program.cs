using System;

namespace Complex_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Complex z1 = new Complex();
            Console.WriteLine($"z1={z1.real}+{z1.imaginary}i");
            Complex z2= new Complex();
            Console.WriteLine($"z2={z2.real}+{z2.imaginary}i");
            Complex.Sum(z1.real, z2.real, z1.imaginary, z2.imaginary);
            Complex.Substraction(z1.real, z2.real, z1.imaginary, z2.imaginary);
            Complex.Multiply(z1.real, z2.real, z1.imaginary, z2.imaginary);
            Console.WriteLine("Enter the power of the complex number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the complex number z1 or z2: ");
            string c = Console.ReadLine();
            bool d = true;
            while(d==true)
            {
                if(c=="z1")
                {
                    Complex.Power(c,z1.real, z1.imaginary,n1);
                    d = false;
                }else if(c=="z2")
                {
                    Complex.Power(c,z2.real, z2.imaginary, n1);
                    d = false;
                }else
                {
                    Console.WriteLine("Try another character: ");
                    c = Console.ReadLine();
                }
            }
            Console.WriteLine("Enter the complex number z1 or z2 to find its polar form: ");
            c = Console.ReadLine();
            d = true;
            while (d == true)
            {
                if (c == "z1")
                {
                    Complex.PolarForm(c, z1.real, z1.imaginary);
                    d = false;
                }
                else if (c == "z2")
                {
                    Complex.PolarForm(c, z2.real, z2.imaginary);
                    d = false;
                }
                else
                {
                    Console.WriteLine("Try another character: ");
                    c = Console.ReadLine();
                }

            }
            Console.WriteLine("Enter the n to find the polar form to the power of n of the complex number:");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the complex number z1 or z2 to find its polar form to the power of {n2}: ");
            c = Console.ReadLine();
            d = true;
            while (d == true)
            {
                if (c == "z1")
                {
                    Complex.PolarFormPower(c, z1.real, z1.imaginary,n2);
                    d = false;
                }
                else if (c == "z2")
                {
                    Complex.PolarFormPower(c, z2.real, z2.imaginary,n2);
                    d = false;
                }
                else
                {
                    Console.WriteLine("Try another character: ");
                    c = Console.ReadLine();
                }

            }
        }
    }
}
