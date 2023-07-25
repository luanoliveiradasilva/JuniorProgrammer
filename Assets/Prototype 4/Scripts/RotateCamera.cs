using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Prototype_4.Scripts
{
    public class RotateCamera : MonoBehaviour
    {

        [SerializeField] private float rotateSpeed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var moveHorizonta = Input.GetAxis("Horizontal");

            transform.Rotate(Vector3.up, rotateSpeed * moveHorizonta * Time.deltaTime);
        }
    }
}
