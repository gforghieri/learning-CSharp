using System;

namespace DateTimeDiv
{
    class Program
    {

        private static DateTime endDate = new DateTime(2005, 12, 22);
        private static DateTime startDate = new DateTime(2005, 5, 2);

        static void Main(string[] args)
        {
            Console.WriteLine(DateTimeNeg(endDate,startDate));
        }

        static  TimeSpan DateTimeNeg(DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 - dateTime2;
        }


        static void DateTimeDiv(TimeSpan timeSpan1, TimeSpan timespan2)
        {

        }

    }
}
