using System;
using System.Collections.Generic;
using System.Linq;

public class WeaponFactory
{
    public IWeapon CreateWeapon(IList<string> weaponData)
    {
        var weaponTypeAndRarity = weaponData[1].Split();
        string weaponType = weaponTypeAndRarity[1];

        switch (weaponType)
        {
            case "Axe":
                var axeNameAndRarityType = weaponData[1].Split();
                string axeRarityType = axeNameAndRarityType[0];
                string axeName = weaponData[2];
                IWeapon axe = new Axe(axeName, axeRarityType);
                return axe;
            case "Knife":
                var knifeNameAndRarityType = weaponData[1].Split();
                string knifeRarityType = knifeNameAndRarityType[0];
                string knifeName = weaponData[2];
                IWeapon knife = new Knife(knifeName, knifeRarityType);
                return knife;
            case "Sword":
                var swordNameAndRarityType = weaponData[1].Split();
                string swordRarityType = swordNameAndRarityType[0];
                string swordName = weaponData[2];
                IWeapon sword = new Sword(swordName, swordRarityType);
                return sword;
            default:
                throw new NotImplementedException("Weapon not implemented!");
        }
    }
}