using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
//	public Transform player1;
//	public Transform player2;
//
//	//thrower fields
//	private Vector3 players_Last_Position;
//	public Transform otherplayer;
//	private Rigidbody2D heldObjRb;
//	public float throwspeed;
//	public LayerMask enemyLayer;
//	private RaycastHit2D hit;
//	private float range;
//	Vector2 pos;
//
//
//	void Start ()
//	{
//		throwspeed = 5;
//		heldObjRb = null;
//
//		range = 10f;
//	hit =  Physics2D.Raycast(transform.position, Vector2.right);
//	}
//
//
//	void Update ()
//	{
//		pos = new Vector2 (transform.position.x, transform.position.y); //should i move the var to start???
//
//		Debug.DrawRay (pos, transform.right * range, Color.green);
//	
//		if (Physics2D.Raycast (pos, Vector2.right, range))
//		{
//			
//			if (Input.GetKeyDown ("m"))
//			{
//				if (heldObjRb == null)
//				{
//					Transform objectHit = hit.transform
//					ObjectHit = parentPlayer;
//					heldObjRb = otherObj.gameObject.GetComponent<Rigidbody2D> ();
//					heldObjRb.velocity = Vector2.zero;
//					Debug.Log ("grab");
//
//				}
//
//
//			} else if (Input.GetKeyUp ("m"))
//			{
//				if (heldObjRb != null)
//				{
//
//					players_Last_Position = otherplayer.position;
//					Vector2 throwDirection = new Vector2 (players_Last_Position.x - transform.position.x, players_Last_Position.y - transform.position.y);
//					heldObjRb.velocity = (throwDirection * throwspeed);
//					print (throwDirection);
//					player1.transform.DetachChildren ();
//					heldObjRb = null;
//					Debug.Log ("thrown");
//				}
//			}
//		}
//		public void grab ( Transform otherObj, Transform parentPlayer)
//		{
//
//			if ( heldObjRb == null)
//			{
//				otherObj.parent = parentPlayer;
//				heldObjRb = otherObj.gameObject.GetComponent<Rigidbody2D> ();
//				heldObjRb.velocity = Vector2.zero;
//				Debug.Log ("grab");
//
//			}
//
//
//		}
//
//
//		public void thrower ()
//		{
//
//			if ( heldObjRb != null)
//			{
//
//				players_Last_Position = otherplayer.position;
//				Vector2 throwDirection = new Vector2 (players_Last_Position.x - transform.position.x, players_Last_Position.y - transform.position.y);
//				heldObjRb.velocity = (throwDirection * throwspeed);
//				print (throwDirection);
//				player1.transform.DetachChildren ();
//				heldObjRb = null;
//
//				//Now you have the position of the player when you seen it
//				// stored as a variable
//			}

}