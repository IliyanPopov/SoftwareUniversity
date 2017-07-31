public class Startup
{
    public static void Main()
    {
        WeaponFactory weaponFactory = new WeaponFactory();
        InfernoInMemoryRepository infernoInMemoryRepository = new InfernoInMemoryRepository();

        IEngine engine = new Engine(infernoInMemoryRepository, weaponFactory);
        engine.Run();
    }
}