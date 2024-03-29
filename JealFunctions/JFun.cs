using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JealTest
{
    public class JFun
    {


        public static string CapitalNames(string str)
        {
            string result = str;
            var reg = new Regex("^[a-zA-Z]+$");
            if (!string.IsNullOrEmpty(str))
            {
                var words = str.Split(' ');
                for (int index = 0; index < words.Length; index++)
                {
                    var s = words[index];
                    
                    if (reg.IsMatch(s))
                    {
                       words[index] = s[0].ToString().ToUpper() + s.Substring(1).ToLower();
                       result = string.Join(" ", words);
                    }
                    else
                    {
                        Console.WriteLine("Only Strings Allowed in Names");
                        result = "";
                        break;                       
                    }                    
                }                             
              
            }
            return result;
        }

        public static string ReducedFraction(string input)
        {
            Regex regex = new Regex(@"[\d]");
            string[] i = input.Split('/');

            try
            {
                int Operand1 = Convert.ToInt32(i[0]);
                int Operand2 = Convert.ToInt32(i[1]);
                if (regex.IsMatch(i[0]) && regex.IsMatch(i[1]) && (Operand1 !=0 && Operand2 !=0))
                {
                    int Numerator = Operand1;
                    int Denominator = Operand2;
                    int divisor = gcd(Operand1, Operand2);

                    if (divisor != 1)
                    {
                        Numerator = division(Operand1, divisor);
                        Denominator = division(Operand2, divisor);
                    }

                    return Denominator == 1 ? Numerator.ToString() : Numerator + "/" + Denominator;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    return "";
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Invalid Input");
                return "";
            }

        } 
        static int gcd(int a, int b)
        {
            //gcd using Euclid’s algorithm
            while (a != b)
                if (a < b) b = b - a;
                else a = a - b;
            return (a);
        }

        static int division(int a, int b)
        {
            int remainder = a, quotient = 0;
            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }
            return (quotient);
        }
    }
}
