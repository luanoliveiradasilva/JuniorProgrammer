﻿using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Prototype_3.Scripts
{
    internal class RepeatBackground: MonoBehaviour
    {

        private Vector3 startPosition;
        private float repeatWith;
        private void Start()
        {
            startPosition = transform.position;
            repeatWith = GetComponent<BoxCollider>().size.x / 2;
        }
        private void Update()
        {
            if(transform.position.x < startPosition.x - repeatWith)
            {
                transform.position = startPosition;
            }
        }
    }
}
