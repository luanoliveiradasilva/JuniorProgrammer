using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Prototype_3.Scripts
{
    public class PlayerController : MonoBehaviour
    {

        private Rigidbody rigidBody;
        [SerializeField] private float jumpForce;
        [SerializeField] private float gravityModifier;
        [SerializeField] private bool isOnGround = true;
        public bool gameOver = false;

        // Start is called before the first frame update
        void Start()
        {
            rigidBody = GetComponent<Rigidbody>();
            Physics.gravity *= gravityModifier;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
            {
                rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;

            }
            else if (collision.gameObject.CompareTag("Obstacle"))
            {
                gameOver = true;
                Debug.Log("Game Over");
            }
        }
    }
}
