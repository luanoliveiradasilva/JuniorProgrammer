using UnityEngine;

namespace Assets.Prototype_3.Scripts
{
    internal class MoveLeft: MonoBehaviour
    {

        private float speed = 30;

        private void Start()
        {
            
        }

        private void Update()
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
