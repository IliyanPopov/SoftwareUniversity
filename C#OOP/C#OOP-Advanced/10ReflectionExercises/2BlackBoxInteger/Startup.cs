using System;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();

        var typeOfBlackBoxInt = Type.GetType(nameof(BlackBoxInt));
        var blackBoxIntInstance = Activator.CreateInstance(typeOfBlackBoxInt, new object[] { });
        while (input != "END")
        {
            var data = input.Split('_');
            string commandName = data[0];
            int value =int.Parse(data[1]);

            switch (commandName)
            {
                case "Add":
                    var addMethod = typeOfBlackBoxInt.GetMethod("Add", BindingFlags.Instance | BindingFlags.NonPublic); 
                    addMethod.Invoke(blackBoxIntInstance, new object[] { value });
                    Console.WriteLine(blackBoxIntInstance.GetType().GetField("_intValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxIntInstance));
                    break;
                case "Subtract":
                    var substractMethod = typeOfBlackBoxInt.GetMethod("Substract", BindingFlags.Instance | BindingFlags.NonPublic);
                    substractMethod.Invoke(blackBoxIntInstance, new object[] { value });
                    Console.WriteLine(blackBoxIntInstance.GetType().GetField("_intValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxIntInstance));
                    break;
                case "Multiply":
                    var multiplyMethod = typeOfBlackBoxInt.GetMethod("Multiply", BindingFlags.Instance | BindingFlags.NonPublic);
                    multiplyMethod.Invoke(blackBoxIntInstance, new object[] { value });
                    Console.WriteLine(blackBoxIntInstance.GetType().GetField("_intValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxIntInstance));
                    break;
                case "Divide":
                    var divideMethod = typeOfBlackBoxInt.GetMethod("Divide", BindingFlags.Instance | BindingFlags.NonPublic);
                    divideMethod.Invoke(blackBoxIntInstance, new object[] { value });
                    Console.WriteLine(blackBoxIntInstance.GetType().GetField("_intValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxIntInstance));
                    break;
                case "LeftShift":
                    var lefShiftMethod = typeOfBlackBoxInt.GetMethod("LeftShift", BindingFlags.Instance | BindingFlags.NonPublic);
                    lefShiftMethod.Invoke(blackBoxIntInstance, new object[] { value });
                    Console.WriteLine(blackBoxIntInstance.GetType().GetField("_intValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxIntInstance));
                    break;
                case "RightShift":
                    var rightShift = typeOfBlackBoxInt.GetMethod("RightShift", BindingFlags.Instance | BindingFlags.NonPublic);
                    rightShift.Invoke(blackBoxIntInstance, new object[] { value });
                    Console.WriteLine(blackBoxIntInstance.GetType().GetField("_intValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxIntInstance));
                    break;
            }
            input = Console.ReadLine();
        }
    }
}

