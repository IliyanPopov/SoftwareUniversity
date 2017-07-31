using System;
using System.Linq;

public class Engine : IEngine
{
    private readonly InfernoInMemoryRepository _infernoInMemoryRepository;
    private readonly WeaponFactory _weaponFactory;

    public Engine(InfernoInMemoryRepository infernoInMemoryRepository, WeaponFactory weaponFactory)
    {
        this._infernoInMemoryRepository = infernoInMemoryRepository;
        this._weaponFactory = weaponFactory;
    }

    public void Run()
    {
        var data = Console.ReadLine().Split(';');

        while (data[0] != "END")
        {
            string commandType = data[0];
            switch (commandType)
            {
                //consider changing the repository search, with Repository pattern implementation
                case "Create":
                    IWeapon weapon = this._weaponFactory.CreateWeapon(data);
                    this._infernoInMemoryRepository.Weapons.Add(weapon);
                    break;
                case "Add":
                    string weaponNameToAddGemTo = data[1];
                    int gemInsertIndex = int.Parse(data[2]);
                    var gemClarityTypeAndGemType = data[3].Split();
                    GemClarityType gemClarityType;
                    GemType gemType;
                    Enum.TryParse(gemClarityTypeAndGemType[0], out gemClarityType);
                    Enum.TryParse(gemClarityTypeAndGemType[1], out gemType);
                    var weaponResultAddGem = this._infernoInMemoryRepository.Weapons.FirstOrDefault(w => w.Name == weaponNameToAddGemTo);
                    var gemResult = this._infernoInMemoryRepository.Gems.FirstOrDefault(g => g.Type == gemType && g.ClarityType == gemClarityType);
                    weaponResultAddGem?.AddGem(gemResult, gemInsertIndex);
                    break;
                case "Remove":
                    string weaponNameToRemoveGemFrom = data[1];
                    int gemRemoveIndex = int.Parse(data[2]);
                    var weaponResultRemoveGem = this._infernoInMemoryRepository.Weapons.FirstOrDefault(w => w.Name == weaponNameToRemoveGemFrom);
                    weaponResultRemoveGem?.RemoveGem(gemRemoveIndex);
                    break;
                case "Print":
                    string weaponToPrintName = data[1];
                    var weaponPrintResult = this._infernoInMemoryRepository.Weapons.FirstOrDefault(w => w.Name == weaponToPrintName);
                    Console.WriteLine(weaponPrintResult?.Print());
                    break;
            }

            data = Console.ReadLine().Split(';');
        }

    }
}