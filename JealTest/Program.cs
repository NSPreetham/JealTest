using System;
using JealTest;


namespace JealTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter 1 for Fun with Names and 2 for Fun with fractions");
                int ch = Convert.ToInt16(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Please Enter Names separated by Space");
                        string str = Console.ReadLine();
                        //Console.WriteLine("Hey! I think Names are Fun ");
                        Console.WriteLine(JFun.CapitalNames(str));
                        break;
                    case 2:
                        Console.WriteLine("Please Enter the fraction");
                        string strfrac = Console.ReadLine();
                        // Console.WriteLine("Normalized form of fraction");
                        Console.WriteLine(JFun.ReducedFraction(strfrac));
                        break;
                    default:
                        Console.WriteLine("Not a valid format");
                        break;
                }

                Console.ReadLine();
            }

            catch(Exception e)
            {
                Console.WriteLine("Enter a Valid Choice");
            }
        }




    
        
    }
}
