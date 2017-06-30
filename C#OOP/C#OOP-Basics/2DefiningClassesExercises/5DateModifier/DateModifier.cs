namespace _5DateModifier
{
    using System;

    public class DateModifier
    {
        public double differenceInDays;

        public void CalculateDifferenceInDaysBetweenTwoDates(string date1, string date2)
        {
            var data1 = date1.Split(' ');
            var year1 = int.Parse(data1[0]);
            var month1 = int.Parse(data1[1]);
            var day1 = int.Parse(data1[2]);

            DateTime dt1 = new DateTime(year1, month1, day1);

            var data2 = date2.Split(' ');
            var year2 = int.Parse(data2[0]);
            var month2 = int.Parse(data2[1]);
            var day2 = int.Parse(data2[2]);

            DateTime dt2 = new DateTime(year2, month2, day2);

            TimeSpan duration = dt1 - dt2;


            this.differenceInDays = Math.Abs(Math.Round(duration.TotalDays));
        }
    }
}