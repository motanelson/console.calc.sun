using System;

class calcs { 
    public static Double totals=0.0;
    public static Double values=0.0;

    public static void Writer() 
    {
        totals = totals + values;

        Console.WriteLine("= {0}", totals);
    
    }
    public static bool gets()
    {
        String s = "";
        bool b = false;
        s=Console.ReadLine();
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




class calc {


    public static void Main(String[] args)
    {

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("calc double!");
        calcs.calcLoop();

    }
}





