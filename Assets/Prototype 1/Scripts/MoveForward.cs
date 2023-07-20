using UnityEngine;


namespace Assets.Prototype_1.Scripts
{
    internal class MoveForward: MonoBehaviour
    {
        [SerializeField] private float speed = 40.0f;

        private void Start ()
        {

        }

        private void Update ()
        {

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
    }
}
