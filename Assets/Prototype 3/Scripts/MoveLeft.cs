using UnityEngine;

namespace Assets.Prototype_3.Scripts
{
    internal class MoveLeft: MonoBehaviour
    {

        
        private PlayerController playerControllerScript;
        private float speed = 30;
        private float leftBound = -15;

        private void Start()
        {
            playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        }

        private void Update()
        {
            if(playerControllerScript.gameOver == false)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }

            // if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            //{
            // Destroy(gameObject);
            //}
        }
    }
}
