using UnityEngine;
namespace RPG.Character
{
     [CreateAssetMenu(
            fileName = "character stats",
            menuName =  "RPG/Character stats so",
            order = 0
        )]
    public class CharacterStatsSO : ScriptableObject
    {

        public float health = 100f;
        public float damage = 10f;
        public float walkSpeed = 1f;
        public float runSpeed = 1.25f;
    }

}

