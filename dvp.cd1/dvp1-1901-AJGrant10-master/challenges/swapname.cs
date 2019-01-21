using System;

using System.Collections.Generic;

using System.Text;

using System.Reflection;

namespace Dotnetheaven

{

    class Program

    {

        static void Main()

        {

            string name, Revname = "";

            Console.Write("Entert Your Name : ");

            name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)

            {

                Revname = Revname + name[i];

            }

            Console.WriteLine("Reverse  String  Is  {0}", Revname);

            Console.ReadLine();

        }

    }

}
