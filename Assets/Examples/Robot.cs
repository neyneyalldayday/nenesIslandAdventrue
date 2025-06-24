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

}