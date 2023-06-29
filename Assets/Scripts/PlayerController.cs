using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeedVeichle = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We´ll  move the veichle forward.
        //Vector3.forward Explanation : https://docs.unity3d.com/ScriptReference/Vector3.html
        var movePlayer = Vector3.forward;

        //Time.deltaTime explanation: https://docs.unity3d.com/ScriptReference/Time-deltaTime.html
        transform.Translate(movePlayer * moveSpeedVeichle * Time.deltaTime);        

    }
}
