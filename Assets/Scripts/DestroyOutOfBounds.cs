﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal class DestroyOutOfBounds : MonoBehaviour
    {
        private float topBound = 30.0f;
        private float lowerBound = -10.0f;

        private void Start()
        {
            
        }

        private void Update()
        {
            //Destroy object: Actually, disabled object when active the object.destroy: Reference : https://docs.unity3d.com/ScriptReference/Object.Destroy.html
            if (transform.position.z > topBound)
            {
                Destroy(gameObject);

            }else if (transform.position.z < lowerBound)
            {
                Destroy(gameObject);
            }
        }
    }
}
