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
        public float price = 99.99f;
        //private string name = "McBot";
        public bool isTurnedOn = false;

        public Robot()
        {
            //isTurnedOn = true; 
            float newPrice = CaluclatePrice(0.7f, 1);

            if(newPrice > 75f)
            {
                price = newPrice;
            } 
            else 
            {
                // print("Price is too low foo!!!!");            
                // Debug.LogError("you suck hard");
                Log("you suck bitch");
                Log<int>(age);
                Log(isTurnedOn);
            }
            
        }

        public float CaluclatePrice( float discount, int quantity )
        {
            return (price - ( price * discount )) * quantity; 
        }

        public void Log<Placeholder>(Placeholder message)
        {
            Debug.Log(message);
        }
       

    }

}