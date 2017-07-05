using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        RandomList randomList = new RandomList();
        randomList.Add(1);
        randomList.Add(1);
        randomList.Add(1);
        randomList.Add(2);

        var randomNumber = random.Next(0, randomList.Count);

        randomList.RandomString(randomNumber);
    }
}