using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Cosmoscalc
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {

                 calc.Main();
                 var input = Console.ReadLine();
            }
            
            
        }
    }
    class calcs
    {
        public static Double totals = 0.0;
        public static Double values = 0.0;

        public static void Writer()
        {
            totals = totals + values;

            Console.WriteLine("= {0}", totals);

        }
        public static bool gets()
        {
            String s = "";
            bool b = false;
            s = Console.ReadLine();
            s = s.Trim();
            Console.WriteLine(s);
            if (s == "") return true;
            values = 0.0;
            try
            {
                values = Double.Parse(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public static void calcLoop()
        {
            while (true)
            {
                if (gets()) break;
                Writer();



            }


        }

    }




    class calc
    {


        public static void Main()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("calc double!");
            calcs.calcLoop();

        }
    }






}
