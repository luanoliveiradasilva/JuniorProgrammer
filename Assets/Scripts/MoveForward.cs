using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
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
