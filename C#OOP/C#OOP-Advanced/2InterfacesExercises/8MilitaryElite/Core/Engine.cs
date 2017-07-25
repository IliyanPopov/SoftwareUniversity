using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private readonly IList<ISoldier> _soldiers;

    public Engine()
    {
        this._soldiers = new List<ISoldier>();
    }

    public void Run()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            var data = input.Split(' ').ToList();

            var isCorpsOk = false;
            switch (data[0])
            {
                case "Private":

                    string privateId = data[1];
                    string privateFirstName = data[2];
                    string privateLastName = data[3];
                    decimal privateSalary = decimal.Parse(data[4]);
                    ISoldier privateSoldier =
                        new Private(privateId, privateFirstName, privateLastName, privateSalary);
                    this._soldiers.Add(privateSoldier);

                    break;

                case "LeutenantGeneral":

                    string leutenantGeneraId = data[1];
                    string leutenantGeneralFirstName = data[2];
                    string leutenantGeneralLastName = data[3];
                    decimal leutenantGeneralSalary = decimal.Parse(data[4]);

                    IList<ISoldier> privateSoldiers = ExtractPrivates(data.Skip(5).ToList());

                    ISoldier leutenantGeneral = new LeutenantGeneral(leutenantGeneraId, leutenantGeneralFirstName,
                        leutenantGeneralLastName,
                        leutenantGeneralSalary, privateSoldiers);

                    this._soldiers.Add(leutenantGeneral);
                    break;


                case "Engineer":

                    string engineerId = data[1];
                    string engineerFirstName = data[2];
                    string engineerLastName = data[3];
                    decimal engineerSalary = decimal.Parse(data[4]);
                    Corps corpsEngineer;
                    isCorpsOk = Enum.TryParse(data[5], out corpsEngineer);

                    if (!isCorpsOk)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    IList<IRepair> repairs = new List<IRepair>();
                    for (int i = 6; i < data.Count; i += 2)
                    {
                        string repairName = data[i];
                        int hoursWorked = int.Parse(data[i + 1]);

                        IRepair repair = new Repair(repairName, hoursWorked);
                        repairs.Add(repair);
                    }

                    ISoldier engineer = new Engineer(engineerId, engineerFirstName, engineerLastName,
                        engineerSalary, corpsEngineer, repairs);

                    this._soldiers.Add(engineer);
                    break;


                case "Commando":
                    string commandoId = data[1];
                    string commandoFirstName = data[2];
                    string commandoLastName = data[3];
                    decimal commandoSalary = decimal.Parse(data[4]);
                    Corps corpsCommando;
                    isCorpsOk = Enum.TryParse(data[5], out corpsCommando);

                    if (!isCorpsOk)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    IList<IMission> missions = new List<IMission>();

                    for (int i = 6; i < data.Count - 1; i += 2)
                    {
                        string missionCodeName = data[i];
                        MissionState missionState;
                        bool isSuccessfull = Enum.TryParse(data[i + 1], out missionState);
                        if (!isSuccessfull)
                        {
                            continue;
                        }

                        IMission mission = new Mission(missionCodeName, missionState);
                        missions.Add(mission);
                    }

                    ISoldier commando = new Commando(commandoId, commandoFirstName, commandoLastName,
                        commandoSalary, corpsCommando, missions);
                    this._soldiers.Add(commando);
                    break;


                case "Spy":

                    string spyId = data[1];
                    string spyFirstName = data[2];
                    string spyLastName = data[3];
                    int spyCodeNumber = int.Parse(data[4]);
                    ISoldier spy = new Spy(spyId, spyFirstName, spyLastName, spyCodeNumber);
                    this._soldiers.Add(spy);
                    break;
            }

            input = Console.ReadLine();
        }

        foreach (var soldier in this._soldiers)
        {
            Console.WriteLine(soldier.ToString());
        }
    }

    private IList<ISoldier> ExtractPrivates(IList<string> soldierIds)
    {
        var list = new List<ISoldier>();

        foreach (var soldierId in soldierIds)
        {
            list.Add(this._soldiers.First(s => s.Id == soldierId));
        }

        return list;
    }
}