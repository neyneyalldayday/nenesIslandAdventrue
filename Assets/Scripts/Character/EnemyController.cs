using System;
using UnityEngine;
using RPG.Utility;

namespace RPG.Character
{
    public class EnemyController : MonoBehaviour
    {
        private GameObject player;
        private Movement movementCmp;
        public float chaseRange = 2.5f;
        public float attackRange = 0.75f;
        [NonSerialized] public float distanceFromPlayer;

        private AIBaseState currentState;
        public AIReturnState returnState = new AIReturnState();

        private void Awake()
        {
            currentState = returnState;

            player = GameObject.FindWithTag(Constants.PLAYER_TAG);
            movementCmp = GetComponent<Movement>();
        }

        private void Start()
        {
            currentState.EnterState(this);
        }

        private void Update()
        {
            CalculateDistanceFromPlayer();
            ChasePlayer();

            currentState.UpdateState(this);
        }

        private void ChasePlayer()
        {
            if (distanceFromPlayer > chaseRange) return;

            movementCmp.MoveAgentByDestination(player.transform.position);
        }

        private void CalculateDistanceFromPlayer()
        {
            if (player == null) return;


            Vector3 enemyPosition = transform.position;
            Vector3 playerPosition = player.transform.position;

            distanceFromPlayer = Vector3.Distance(enemyPosition, playerPosition);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(
                transform.position,
                chaseRange
            );
        }
    }
  
}

