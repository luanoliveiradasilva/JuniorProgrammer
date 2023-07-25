
using UnityEngine;

namespace Assets.Prototype_4.Scripts
{
    public class PlayerController: MonoBehaviour
    {

        [SerializeField] private float speedOfPlayer;

        private GameObject focalPoint;

        private Rigidbody rigidBody;

        private void Start()
        {
            rigidBody = GetComponent<Rigidbody>();
            focalPoint = GameObject.Find("Focal Point");
        }

        private void Update()
        {
            var inputVetical = Input.GetAxis("Vertical");

            rigidBody.AddForce(focalPoint.transform.forward * speedOfPlayer * inputVetical);
        }
    }
}
