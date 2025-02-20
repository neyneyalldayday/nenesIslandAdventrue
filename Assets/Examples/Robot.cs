using UnityEngine;
// RPG is the main namespace 
// for our game

namespace RPG.Example
{
    public class Robot : MonoBehaviour
    {
        /*
        Variables
        ============
        n stuff
        */

        public int age = 5;
        private float price = 99.99f;
        //private string name = "McBot";
        public bool isTurnedOn = false;

        public Robot()
        {
            isTurnedOn = true; 
            
        }

    }

}