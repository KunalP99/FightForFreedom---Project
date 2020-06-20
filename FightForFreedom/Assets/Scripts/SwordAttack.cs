using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AttackRight();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AttackLeft();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AttackUp();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AttackDown();
        }
    }

    void AttackRight()
    {
        animator.SetTrigger("RightAttack");
    }

    void AttackLeft()
    {
        animator.SetTrigger("LeftAttack");
    }

    void AttackUp()
    {
        animator.SetTrigger("UpAttack");
    }
    void AttackDown()
    {
        animator.SetTrigger("DownAttack");
    }

}
