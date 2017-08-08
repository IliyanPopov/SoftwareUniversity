//namespace InfernoInfinity.Client.Core
//{
//    using System;
//    using System.Linq;
//    using Common.CustomAttributes;
//    using Common.Utilities;
//    using Contracts;
//    using Contracts.Core;
//    using Data.Repositories;
//    using Models.Contracts.Gems;
//    using Models.Contracts.Weapons;
//    using Models.Enumerations;
//    using Models.Factories;
//    using Models.Models;
//    using Models.Models.Weapons;

//    public class EngineTemp : IEngine
//    {
//        private readonly InfernoInMemoryRepository _infernoInMemoryRepository;
//        private readonly WeaponFactory _weaponFactory;
//        private readonly IReader _reader;
//        private readonly IWriter _writer;

//        public EngineTemp(InfernoInMemoryRepository infernoInMemoryRepository, WeaponFactory weaponFactory, IReader reader, IWriter writer)
//        {
//            this._infernoInMemoryRepository = infernoInMemoryRepository;
//            this._weaponFactory = weaponFactory;
//            this._reader = reader;
//            this._writer = writer;
//        }

//        public void Run()
//        {
//            string input = this._reader.ReadLine();

//            while (input != "END")
//            {
//                var data = input.Split(';');
//                var type = typeof(Weapon);
//                var customAttributes = type.GetCustomAttributes(false);
//                string commandType = data[0];
//                switch (commandType)
//                {
//                    case "Create":
//                        IWeapon weapon = this._weaponFactory.CreateWeapon(data);
//                        this._infernoInMemoryRepository.Weapons.Add(weapon);
//                        break;
//                    case "Add":
//                        string weaponNameToAddGemTo = data[1];
//                        int gemInsertIndex = int.Parse(data[2]);
//                        var gemClarityTypeAndGemType = data[3].Split();
//                        string gemType = gemClarityTypeAndGemType[1];

//                        GemClarityType gemClarityType;
//                        Enum.TryParse(gemClarityTypeAndGemType[0], out gemClarityType);

//                        var weaponResultAddGem = this._infernoInMemoryRepository.Weapons
//                            .FirstOrDefault(w => w.Name == weaponNameToAddGemTo);
//                        var gemResult = this._infernoInMemoryRepository.Gems
//                            .FirstOrDefault(g => g.GetType().Name.ToString() == gemType && g.ClarityType == gemClarityType);

//                        if (weaponResultAddGem != null &&
//                            Validator<IGem>.ValidateRange(weaponResultAddGem.GemSockets, gemInsertIndex))
//                        {
//                            weaponResultAddGem.GemSockets[gemInsertIndex] = gemResult;
//                        }

//                        break;
//                    case "Remove":
//                        string weaponNameToRemoveGemFrom = data[1];
//                        int gemRemoveIndex = int.Parse(data[2]);
//                        var weaponResultRemoveGem =
//                            this._infernoInMemoryRepository.Weapons
//                                .FirstOrDefault(w => w.Name == weaponNameToRemoveGemFrom);
//                        if (weaponResultRemoveGem != null &&
//                            Validator<IGem>.ValidateRange(weaponResultRemoveGem.GemSockets, gemRemoveIndex))
//                        {
//                            weaponResultRemoveGem.GemSockets[gemRemoveIndex] = null;
//                        }

//                        break;
//                    case "Print":
//                        string weaponToPrintName = data[1];
//                        var weaponPrintResult =
//                            this._infernoInMemoryRepository.Weapons.FirstOrDefault(w => w.Name == weaponToPrintName);
//                        this._writer.WriteLine(weaponPrintResult?.Print());
//                        break;
//                    case "Author":
//                        foreach (DescriptionAttribute customAttribute in customAttributes.Where(
//                            c => c.GetType() == typeof(DescriptionAttribute)))
//                        {
//                            this._writer.WriteLine($"Author: {customAttribute.Author}");
//                        }

//                        break;
//                    case "Revision":
//                        foreach (DescriptionAttribute customAttribute in customAttributes.Where(
//                            c => c.GetType() == typeof(DescriptionAttribute)))
//                        {
//                            this._writer.WriteLine($"Revision: {customAttribute.Revision}");
//                        }

//                        break;
//                    case "Description":
//                        foreach (DescriptionAttribute customAttribute in customAttributes.Where(
//                            c => c.GetType() == typeof(DescriptionAttribute)))
//                        {
//                            this._writer.WriteLine($"Class description: {customAttribute.Description}");
//                        }
//                        break;
//                    case "Reviewers":
//                        foreach (DescriptionAttribute customAttribute in customAttributes.Where(
//                            c => c.GetType() == typeof(DescriptionAttribute)))
//                        {
//                            this._writer.WriteLine($"Reviewers: {string.Join(", ", customAttribute.Reviewers)}");
//                        }
//                        break;
//                }

//                input = this._reader.ReadLine();
//            }
//        }
//    }
//}