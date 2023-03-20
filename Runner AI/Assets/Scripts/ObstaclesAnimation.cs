using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesAnimation : MonoBehaviour
{
    public float speed = 1.0f;
    public float strength = 2.5f;
    private float RandomOffset;
    
    
        
    void Start()
    {
        RandomOffset = Random.Range(-2.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x =Mathf.Sin(Time.time * speed + RandomOffset) * strength;
        transform.position = pos;
        
    }
}
