using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backwards
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1 = "";
            int i, l;


            Console.WriteLine("Welcome to Backwards");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Input  A String : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {

                str1 = str1 + str[i];


            }

            Console.WriteLine("Backwards this sentence would read : {0}", str1);
            

        }
    }
}
