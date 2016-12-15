using UnityEngine;
using System.Collections;

public class Controller : actions
{



	void Start ()
	{
		lifeP1 = 3;

	}


	void Update ()
	{
//		Debug.DrawRay (transform.position, transform.right * 10, Color.green);
//		GrabThrow (player1);
		die (lifeP1);
	

		Mspace ();

		if (Input.GetKey (KeyCode.UpArrow))
		{
			MoveUp ();
		}

		if (Input.GetKey (KeyCode.DownArrow))
		{
			MoveDown ();
		}

		if (Input.GetKey (KeyCode.LeftArrow))
		{
			MoveLeft ();
		}

		if (Input.GetKey (KeyCode.RightArrow))
		{
			MoveRight ();
		}
			
		Debug.Log (lifeP1);

		
		if (lifeP1 > 4)
		{
			lifeP1 = 5;
		}
			
				
				

	}


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		


	}


	//	public void duck ()
	//	{
	//
	//
	//		//gameObject.GetComponent<Collider2D> ("Box Collider 2D").isTrigger = false;
	//	}

}
