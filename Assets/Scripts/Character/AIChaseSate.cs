namespace RPG.Character
{
    public class AIChaseState : AIBaseState
    {
        public override void EnterState(EnemyController enemy)
        {

        }

        public override void UpdateState(EnemyController enemy)
        {
            if (enemy.distanceFromPlayer > enemy.chaseRange)
            {
                enemy.SwitchState(enemy.returnState);
                return;
            }

            enemy.movementCmp.MoveAgentByDestination(enemy.player.transform.position);
        }
    }
}