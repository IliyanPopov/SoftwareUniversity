//using System;
//using System.Collections.Generic;

//public class SoldierFactory
//{
//    public ISoldier CreateSoldier(List<string> soldierData)
//    {

//        switch (soldierData[0])
//        {
//            case "Private":
//                string privateId = soldierData[1];
//                string privateFirstName = soldierData[2];
//                string privateLastName = soldierData[2];
//                double privateSalary = double.Parse(soldierData[3]);
//                return new Private(privateId, privateFirstName, privateLastName, privateSalary);

//            case "LeutenantGeneral":
//                string leutenantGeneraId = soldierData[1];
//                string leutenantGeneralFirstName = soldierData[2];
//                string leutenantGeneralLastName = soldierData[2];
//                double leutenantGeneralSalary = double.Parse(soldierData[3]);

//                return new LeutenantGeneral(leutenantGeneraId, leutenantGeneralFirstName, leutenantGeneralLastName, leutenantGeneralSalary);

//            case "Engineer":
//                string engineerId = soldierData[1];
//                string engineerFirstName = soldierData[2];
//                string engineerLastName = soldierData[2];
//                double engineerSalary = double.Parse(soldierData[3]);
//                Corps corpsEngineer;
//                Enum.TryParse(soldierData[4], out corpsEngineer);
//                return new Engineer(engineerId, engineerFirstName, engineerLastName, engineerSalary, corpsEngineer);

//            case "Commando":
//                string commandoId = soldierData[1];
//                string commandoFirstName = soldierData[2];
//                string commandoLastName = soldierData[2];
//                double commandoSalary = double.Parse(soldierData[3]);
//                Corps corpsCommando;
//                Enum.TryParse(soldierData[4], out corpsCommando);
//                return new Commando(commandoId, commandoFirstName, commandoLastName, commandoSalary, corpsCommando);

//            case "Spy":
//                string spyId = soldierData[1];
//                string spyFirstName = soldierData[2];
//                string spyLastName = soldierData[2];
//                int spyCodeNumber = int.Parse(soldierData[3]);
//                return new Spy(spyId, spyFirstName, spyLastName, spyCodeNumber);
//            default:
//                throw new NotImplementedException();
//        }
//    }
//}

