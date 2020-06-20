using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Animator animator;
    public float attackSpeed;
    float timeBtwAttack;

    // Update is called once per frame
    void Update()
    {
        //Time.time is the amount of seconds since application started
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time > timeBtwAttack)
        {
            AttackRight();
            //determines how quick character can attack as at this point in time, timeBtwAttack is 1 second longer then Time.time 
            timeBtwAttack = Time.time + attackSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time > timeBtwAttack)
        {
            AttackLeft();
            timeBtwAttack = Time.time + attackSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > timeBtwAttack)
        {
            AttackUp();
            timeBtwAttack = Time.time + attackSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time > timeBtwAttack)
        {
            AttackDown();
            timeBtwAttack = Time.time + attackSpeed;
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
