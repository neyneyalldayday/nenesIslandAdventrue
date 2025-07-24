using System;
using UnityEngine;
// RPG is the main namespace 
// for our game

namespace RPG.Example
{
    public class Robot : MonoBehaviour
    {
        private Battery includedBattery;

        Robot()
        {
            includedBattery = new Battery(80f);
            print(includedBattery.health);
            Charger.ChargeBattery(includedBattery);
            print(includedBattery.health);
            print(Charger.chargerInUse);
            
        }
    }

    public class Battery
    {
        public float health;

        public Battery(float newHealth)
        {
            health = newHealth;
            Debug.Log("New battery created");
        }
    }

    static class Charger
    {
        public static bool chargerInUse = false;

        public static void ChargeBattery(Battery batterToCharge)
        {
            chargerInUse = true;
            batterToCharge.health = 100f;
        }
    }

}