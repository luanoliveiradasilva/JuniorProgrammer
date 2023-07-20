using UnityEngine;

namespace Assets.Scripts
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
