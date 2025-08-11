using System;
using UnityEngine;
using RPG.Utility;

namespace RPG.Character
{
    public class EnemyController : MonoBehaviour
    {
        private GameObject player;
        public float chaseRange = 2.5f;
        public float attackRange = 0.75f;
        [NonSerialized] public float distanceFromPlayer;

        private void Awake()
        {
            player = GameObject.FindWithTag(Constants.PLAYER_TAG);
        }

        private void Update()
        {
            CalculateDistanceFromPlayer();
        }

        private void CalculateDistanceFromPlayer()
        {
            if (player == null) return;


            Vector3 enemyPosition = transform.position;
            Vector3 playerPosition = player.transform.position;

            distanceFromPlayer = Vector3.Distance(enemyPosition, playerPosition);
        }
    }
  
}

