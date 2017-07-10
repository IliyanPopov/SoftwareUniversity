using System;
using System.Text;

public class Worker : Human
{
    private const double MinWorkingHoursPerDay = 1;
    private const double MaxWorkingHoursPerDay = 12;
    private const double MinimumSalary = 10;
    private const double WorkDaysInWeek = 5;
    private double _weekSalary;
    private double _workHoursPerDay;

    public Worker(string firstName, string lastName, double weekSalary, double workingHoursPerDay) : base(firstName,
        lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workingHoursPerDay;
    }

    public double WorkHoursPerDay
    {
        get { return this._workHoursPerDay; }
        set
        {
            if (value < MinWorkingHoursPerDay || value > MaxWorkingHoursPerDay)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }

            this._workHoursPerDay = value;
        }
    }

    public double WeekSalary
    {
        get { return this._weekSalary; }
        set
        {
            if (value < MinimumSalary)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this._weekSalary = value;
        }
    }

    public double CalculateMoneyPerHour()
    {
        //  var daySalary = ;
        var moneyPerHour = (this.WeekSalary / WorkDaysInWeek) / this.WorkHoursPerDay;

        return moneyPerHour;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:F2}")
            .AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}")
            .AppendLine($"Salary per hour: {CalculateMoneyPerHour():F2}");

        return sb.ToString();
    }
}