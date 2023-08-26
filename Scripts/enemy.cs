using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;


    public int maxHealth = 100;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    { 
        currentHealth -= damage;
        animator.SetTrigger("Hurt");


        if (currentHealth < 0) 
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("IsDead", true);
        GetComponent<Collider2D>().enabled = false;
    }

    // Update is called once per frame
}
