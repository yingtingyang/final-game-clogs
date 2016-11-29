using UnityEngine;
using System.Collections;

public class actions : Movement 
{
	
	private Rigidbody2D heldObjRb ;
	public float throwspeed;


	//grab fields
	public Transform player1;
	public Transform player2;

	//thrower fields
	private Vector3 players_Last_Position;
	private Transform otherplayer;









	public actions() 
	{

		otherplayer = GameObject.Find("player 2").transform;
		throwspeed = 5;
		heldObjRb = null;
	}

	public void grab(string button, Collider2D otherObj)
	{
		
			if (Input.GetKeyDown(button) && heldObjRb == null)
			{
			    otherObj.transform.parent = player1;
				heldObjRb = otherObj.gameObject.GetComponent<Rigidbody2D>();
				heldObjRb.velocity = Vector2.zero;
				Debug.Log("grab");

			}
	

	}


	public void thrower(string button)
	{

		if (Input.GetKeyUp(button) && heldObjRb != null) {

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
