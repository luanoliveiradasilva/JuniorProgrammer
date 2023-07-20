using UnityEngine;

namespace Assets.Prototype_2.Scripts
{
    internal class DetectCollisions: MonoBehaviour
    {


        private void Start()
        {
            
        }
        private void Update()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
