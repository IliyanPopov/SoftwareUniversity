public class Startup
{
    public static void Main()
    {
        Clinic clinic = new Clinic("ss",21);
        IEngine engine = new Engine();
        engine.Run();
    }
}

