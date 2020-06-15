using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform player;
    public float moveSpeed;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //finds object tagged with "player" and gets the transform component
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //sets the float based on where the players position is
        animator.SetFloat("Horizontal", player.position.x);
        animator.SetFloat("Vertical", player.position.y);
        animator.SetFloat("Speed", moveSpeed);

        //move the enemy towards the player
        if (Vector2.Distance(transform.position, player.position) > 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
       
        
    }    

}
