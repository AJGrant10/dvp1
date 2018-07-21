using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class AgeConvert
    {
        public static void Converter(string[] args)
        {
    
            int years, days, hours, minutes, seconds;
            Console.WriteLine("How old are you");
            years = Convert.ToInt32(Console.ReadLine());
            days = 365 * years;
            hours = days * 24;
            minutes = 60 * days;
            seconds = 60 * minutes;
            Console.WriteLine("Next Time answer say " + days +" days or");
            Console.WriteLine(hours + " hours or ");
            Console.WriteLine(minutes  +" minutes or");
            Console.WriteLine(seconds + " seconds");
        }

        //How do I call this class from 
        //Hello?
    }
}
