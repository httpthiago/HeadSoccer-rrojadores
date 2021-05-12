using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float constantSpeed = 10f;

    public Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = constantSpeed * (rb.velocity.normalized);
        //Debug.Log(rb.velocity);
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero; transform.position = startPosition;
    } 

    
}
