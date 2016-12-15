using UnityEngine;
using System.Collections;

public class grabthrowP2 : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    private Vector3 players_Last_Position;
    private Transform otherplayer;
    private Rigidbody2D heldObjRb = null;
    public float throwspeed = 10;
    Animator player_2;

    void Awake()
    {
        otherplayer = GameObject.Find("player 1").transform;
        player_2 = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.transform.CompareTag("hazards"))
        {
            if (Input.GetKey("f") && heldObjRb == null)
            {
                player_2.Play("grabP2");
                otherObj.transform.parent = player1;
                heldObjRb = otherObj.gameObject.GetComponent<Rigidbody2D>();
                heldObjRb.velocity = Vector2.zero;
                Debug.Log("grab");

            }
        }
    }
    void Update()
    {
        if (Input.GetKey("g") && heldObjRb != null)
        {
            player_2.Play("throwP2");

            players_Last_Position = otherplayer.position;
            Vector2 throwDirection = new Vector2(players_Last_Position.x - transform.position.x, players_Last_Position.y - transform.position.y);
            heldObjRb.velocity = (throwDirection * throwspeed);
            print(throwDirection);
            player1.transform.DetachChildren();
            heldObjRb = null;

            //Now you have the position of the player when you seen it
            // stored as a variable
        }

    }

}