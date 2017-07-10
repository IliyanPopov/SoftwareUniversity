using System;

public class Program
{
    public static void Main()
    {
        var studentData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string studetFirstName = studentData[0];
        string studetLastName = studentData[1];
        string facultyNumber = studentData[2];

        var workerData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string workerFirstName = workerData[0];
        string workerLastName = workerData[1];
        double salary = double.Parse(workerData[2]);
        double workingHours = double.Parse(workerData[3]);


        Student student;
        try
        {
            student = new Student(studetFirstName, studetLastName, facultyNumber);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Worker worker;
        try
        {
            worker = new Worker(workerFirstName, workerLastName, salary, workingHours);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine(student.ToString());
        Console.WriteLine(worker.ToString());
    }
}