using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;


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
        }

        private void MovePlayer()
        {
            agent.Move(movementVector);
        }

        public void HandleMove(InputAction.CallbackContext context)
        {
            Vector2 input = context.ReadValue<Vector2>();
            movementVector = new Vector3(input.x, 0, input.y);

            print(movementVector);
        }
    // Start is called before the first frame update

    }

}


