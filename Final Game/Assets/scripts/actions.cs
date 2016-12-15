using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class actions : Movement
{
	
	private Rigidbody2D heldObjRb;
	public float throwspeed;


	//grab fields
	public Transform player1;
	public Transform player2;

	//thrower fields
	private Vector3 players_Last_Position;
	public Transform otherplayer;

	// die fields
	public int lifeP1;
	public int lifeP2;

	//raycast fields
	public LayerMask enemyLayer;

	private float range;






	void Start ()
	{
		lifeP1 = 3;
		lifeP2 = 3;

		throwspeed = 5;
		heldObjRb = null;

		range = 10f;

	}




	public bool isDead (int playerlife)
	{
		if (playerlife < 0)
		{
			return true;
		} else
		{
			return false;

		}
			
	}


	public void die (int playerlife)
	{
		if (isDead (playerlife))
		{
			Destroy (gameObject);
		}
 
	}

//
//	public void dodge (GameObject otherObj, string button)
//	{
//		if (Input.GetKeyDown (button))
//		{
//			if (otherObj.transform.CompareTag ("player"))
//			{	
//				GetComponent<BoxCollider2D> ().enabled = false;
//			}
//		}
//	}

	public void GrabThrow ( Transform parentPlayer)
	{
//		Vector2 pos = new Vector2 (transform.position.x, transform.position.y);



		RaycastHit2D hit = Physics2D.Raycast (transform.position, transform.right, range,enemyLayer);

		if ( hit.collider != null)
		{

			if (Input.GetKey ("m") )
			{
				if (heldObjRb == null)
				{
					Transform objectHit = hit.transform;
					objectHit.transform.parent = transform.parent;
					heldObjRb = objectHit.transform.gameObject.GetComponent<Rigidbody2D> ();
					heldObjRb.velocity = Vector2.zero;
					Debug.Log ("grab");
					Debug.Log (heldObjRb);

				}


			}  if (Input.GetKeyUp ("m"))
			{
				if (heldObjRb != null)
				{

					players_Last_Position = otherplayer.position;
					Vector2 throwDirection = new Vector2 (players_Last_Position.x - transform.position.x, players_Last_Position.y - transform.position.y);
					heldObjRb.velocity = (throwDirection * throwspeed);
					print (throwDirection);
					player1.transform.DetachChildren ();
					heldObjRb = null;
					Debug.Log ("thrown");

				}
		    }
	    }
	}
}
