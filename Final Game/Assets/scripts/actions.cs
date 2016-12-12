using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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

	// die fields
	public int lifeP1 ;
	public int lifeP2;






	void Start() 
	{
		lifeP1 = 3;
		lifeP2 = 3;
		otherplayer = GameObject.Find("player 2").transform;
		throwspeed = 5;
		heldObjRb = null;

	}


	public void grab(string button, Collider2D otherObj,Transform parentPlayer)
	{
		
			if (Input.GetKeyDown(button) && heldObjRb == null)
			{
				otherObj.transform.parent = parentPlayer;
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
   

	public bool isDead(int playerlife)
	{
		if (playerlife <= 0)
		{
			return true;
		}
		else 
		{
			return false;

		}
			
	}


	public void die(int playerlife) 
	{
		if (isDead(playerlife)) 
	{
		Destroy (gameObject);
	}
 
	}
		

	public void dodge(Collider2D otherObj,string button)
	{
		if (Input.GetKeyDown (button)) 
		{
			if (otherObj.transform.CompareTag ("player"))
			{	
				GetComponent<BoxCollider2D>().enabled = false;
			}
		}
	}



}
