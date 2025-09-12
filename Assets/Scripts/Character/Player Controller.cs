
using UnityEngine;
namespace RPG.Character
{
    public class PlayerController : MonoBehaviour
    {
        public CharacterStatsSO stats;
        private Health healthCmp;
        private Combat combatCmp;
        private void Awake()
        {

            if (stats == null)
            {
                Debug.LogWarning($"{name} does not have stats yet.");
            }

            healthCmp = GetComponent<Health>();
            combatCmp = GetComponent<Combat>();
        }
        
                private void Start()
        {
            healthCmp.healthPoints = stats.health;
            combatCmp.damage = stats.damage;
        }
 
}
 
}
