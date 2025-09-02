using UnityEngine;

namespace RPG.Character
{
    public class AIReturnState : AIBaseState
    {
        public override void EnterState(EnemyController enemy)
        {
            Debug.Log("entering return state");
        }


        public override void UpdateState(EnemyController enemy)
        {
            Debug.Log("entering update state");
        }
    }
}