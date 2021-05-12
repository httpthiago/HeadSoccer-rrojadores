using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1;
    public Rigidbody2D player;
    private float movement;
    public float speed, jumpForce;

    private bool jump, isgrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1){
            movement = Input.GetAxisRaw("Horizontal1");
        jump = Input.GetButtonDown("Jump1");
        player.velocity = new Vector2(movement * speed, player.velocity.y);

        }
        else{
        movement = Input.GetAxisRaw("Horizontal2");
        jump = Input.GetButtonDown("Jump2");
        player.velocity = new Vector2(movement * speed, player.velocity.y);

        }
        
        
        if (jump == true && isgrounded == true)
        {
            player.AddForce(new Vector2(0, jumpForce));
            isgrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D coli)
    {
        if (coli.gameObject.layer == 8)
        {
            isgrounded = true;
        }

    }
    
}
