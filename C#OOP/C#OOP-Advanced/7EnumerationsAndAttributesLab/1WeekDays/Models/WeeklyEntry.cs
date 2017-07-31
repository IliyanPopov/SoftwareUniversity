using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay _weekday;
    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this._weekday);
        this.Notes = notes;
    }

    public WeekDay Weekday
    {
        get { return this._weekday; }
    }

    public string Notes { get; private set; }


    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var weekdayComparison = this.Weekday.CompareTo(other.Weekday);
        if (weekdayComparison != 0) return weekdayComparison;
        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.Weekday} - {this.Notes}";
    }
}