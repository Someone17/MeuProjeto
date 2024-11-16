using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startingVelocity = new Vector2(5f, 4f);

    public GameManager gameManager;
    
    public void ResetBall(){
       
        transform.position = Vector3.zero;

        if (rb == null) rb = GetComponent<Rigidbody2D>();
       
        rb.velocity = startingVelocity;
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Wall")){
            
            Vector2 newVelocity = rb.velocity;
            
            newVelocity.y = -newVelocity.y;
            
            rb.velocity = newVelocity;
        }
         if(collision.gameObject.CompareTag("Player")){
            
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
            rb.velocity *= 1.1f;
        }
        if(collision.gameObject.CompareTag("WallP1")){
            gameManager.ScorePlayer1();
            ResetBall();
        }
        if(collision.gameObject.CompareTag("WallP2")){
            gameManager.ScorePlayer2();
            ResetBall();
        }
    }
}
