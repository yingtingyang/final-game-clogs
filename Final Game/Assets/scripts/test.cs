using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{

	public LayerMask enemyLayer;
	//	private RaycastHit2D hit;
	private float range;
	Vector2 pos;


	void Start ()
	{
		range = 10f;
//		hit=  Physics2D.Raycast(transform.position, Vector2.right);
	}


	void Update ()
	{
		pos = new Vector2 (transform.position.x, transform.position.y); //should i move the var to start???

		Debug.DrawRay (pos, transform.right * range, Color.green);
	
		if (Physics2D.Raycast (pos, Vector2.right, range))
		{
			if (Input.GetKeyDown ("m"))
			{
				Debug.Log ("dragged");

			} else if (Input.GetKeyUp ("m"))
			{
				Debug.Log ("thrown");
			}
		}
	}
}
