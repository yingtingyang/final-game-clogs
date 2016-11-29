using UnityEngine;
using System.Collections;

public class hazarddamage : MonoBehaviour {

    public int attackDamage = 33;               // The amount of health taken away per attack.
    GameObject player;                          // Reference to the player GameObject.
    healthsystem playerHealth;                  // Reference to the player's health.
   // Animator anim;                              // Reference to the animator component.

    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<healthsystem>();
        //anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            if (playerHealth.currentHealth > 0)
            {
                // ... damage the player.
                playerHealth.TakeDamage(attackDamage);
            }else
            if (playerHealth.currentHealth <= 0)
            {
                // ... tell the animator the player is dead.
                // anim.SetTrigger("PlayerDead");
                Debug.Log("dead");
            }
        }
    }
        // Update is called once per frame
        void Update () {
	
	}
}
