using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using UnityEngine.UIElements;


namespace RPG.Character
{
    public class Movement : MonoBehaviour
    {
        private NavMeshAgent agent;
        private Vector3 movementVector;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            MovePlayer();
            Rotate();
        }

        private void MovePlayer()
        {
            Vector3 offset = movementVector * Time.deltaTime * agent.speed;
            agent.Move(offset);
        }

        public void HandleMove(InputAction.CallbackContext context)
        {
            Vector2 input = context.ReadValue<Vector2>();
            movementVector = new Vector3(input.x, 0, input.y);
        }

        private void Rotate()
        {
            if (movementVector == Vector3.zero) return;
          
            Quaternion startRotation = transform.rotation;
            Quaternion endRotation = Quaternion.LookRotation(movementVector);
        } 

    }

}


