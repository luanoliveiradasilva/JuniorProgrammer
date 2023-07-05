using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeedVeichle = 10.0f;
    private float turnSpeed = 25.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float veticalInput = Input.GetAxis("Vertical");

        // We´ll  move the veichle forward.
        //Vector3.forward Explanation : https://docs.unity3d.com/ScriptReference/Vector3.html
        var movePlayer = Vector3.forward;
        var moveVector = Vector3.up;

        //Time.deltaTime explanation: https://docs.unity3d.com/ScriptReference/Time-deltaTime.html
        //Move the car direction forward with input vertical input.
        transform.Translate(movePlayer * moveSpeedVeichle * Time.deltaTime * veticalInput);

        //Move the car in direction up with rotate left and right.
        transform.Rotate(moveVector * Time.deltaTime * turnSpeed * horizontalInput);
        

    }
}
