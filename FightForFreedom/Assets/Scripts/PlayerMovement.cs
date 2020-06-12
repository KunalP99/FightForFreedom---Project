using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigid;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Input - getting horizontal and vertical movement and storing it in Vector2 movement
        movement.x = Input.GetAxisRaw("Horizontal"); //gives value from -1 to 0. Right arrow = 1, left arrow = -1, nothing = 0
        movement.y = Input.GetAxisRaw("Vertical");

        //sets the float in the animator parameter section 
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() //when dealing with physics (Rigidbody2d) used fixed update otherwise use update
    {
        //Movement
        rigid.MovePosition(rigid.position + movement * moveSpeed * Time.deltaTime);
    }
}
