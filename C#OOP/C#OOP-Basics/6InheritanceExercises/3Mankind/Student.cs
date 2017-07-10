using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private const int MinFacultyNumberLenght = 5;
    private const double MaxFacultyNumberLenght = 10;
    private string _facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return this._facultyNumber; }
        set
        {
            if (value.Length < MinFacultyNumberLenght || value.Length > MaxFacultyNumberLenght ||
                !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this._facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");

        return sb.ToString();
    }
}