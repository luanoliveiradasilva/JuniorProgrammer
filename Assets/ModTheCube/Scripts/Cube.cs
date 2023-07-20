using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float timeRender = 0.0f;
    private float time = 0.5f;
    private float moveSpeed = 15.0f;

    void Start()
    {
        transform.position = new Vector3(0, 4, 0);
        transform.localScale = Vector3.one * 2.3f;
        
        Material material = Renderer.material;        
    }
    
    void Update()
    {

        if (Time.time > timeRender)
        {
            timeRender = Time.time + time;
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
        
        transform.Rotate(20.0f * Time.deltaTime * moveSpeed, 0.0f, 0.0f);
    }
}
