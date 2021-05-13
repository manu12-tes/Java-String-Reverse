using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_String_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una cadeana");
            String a = Console.ReadLine();

            char[] cadena1 = a.ToCharArray();
            char [] cadena2 = a.ToCharArray();
            Array.Reverse(cadena2);
            bool esPalindromo = false;

            for (int n = 0; n < a.Length; n++)
            {
                if (cadena1[n] == cadena2[n])
                {
                    esPalindromo = true;
                    break;
                }
                else
                {
                    esPalindromo = false;
                }
            }

            if (esPalindromo)
            {
                Console.Write("Si");
            }else { Console.Write("No"); }

        }
    }
}
