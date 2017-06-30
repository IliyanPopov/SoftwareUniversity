namespace _5DateModifier
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier dt = new DateModifier();
            dt.CalculateDifferenceInDaysBetweenTwoDates(date1,date2);
            Console.WriteLine(dt.differenceInDays);
        }
    }
}