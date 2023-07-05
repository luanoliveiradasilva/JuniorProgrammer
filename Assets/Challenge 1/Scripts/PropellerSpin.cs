using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
        transform.Rotate(0.0f, 0.0f, 15.0f);
    }
}
