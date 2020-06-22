using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform player;

    public float moveSpeed;
    public Animator animator;
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        //finds object tagged with "player" and gets the transform component
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //sets the float in the animator based on where the players position is
        animator.SetFloat("Horizontal", player.position.x);
        animator.SetFloat("Vertical", player.position.y);
        animator.SetFloat("Speed", moveSpeed);

        //move the enemy towards the player
        if (Vector2.Distance(rigid.transform.position, player.position) > 0)
       {
           //moves from original position to the player position at the move speed set in the inspector * time, so different speed computers runs the game normally
           rigid.transform.position = Vector2.MoveTowards(rigid.transform.position, player.position, moveSpeed * Time.deltaTime);
       }
   
    }

}
