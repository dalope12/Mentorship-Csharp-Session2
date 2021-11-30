using System;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hi = 3;

            Arrays arraysSession = new Arrays();
            arraysSession.todaysDate("10","December","2000","3","10");

            Console.WriteLine("Hey user, this is today's date : " + arraysSession.todaysDate2("18", "November", "2021"));
            arraysSession.month = "January";
            Console.WriteLine("Hey user, tomorrow's date : " + arraysSession.todaysDate2("19", arraysSession.month, "2022"));

            //Arrays.Arrays_method();

            Console.ReadKey();
        }
    }
}
