using UnityEngine;
using System.Collections;

public class Controller2 : actions
{




	void Start ()
	{
		lifeP2 = 3;
		otherplayer = GameObject.Find ("player 1").transform;

		
	}

	void Update ()
	{
//		for(int i=0 ; i<= otherObj.Length;i++)
//		{
//		GrabThrow (otherObj[i],player2);
//		}
		 
//		thrower ("x");
		die (lifeP2);
	

		Mspace ();

		if (Input.GetKey (KeyCode.W))
		{
			MoveUp ();
		}

		if (Input.GetKey (KeyCode.S))
		{
			MoveDown ();
		}

		if (Input.GetKey (KeyCode.A))
		{
			MoveLeft ();
		}

		if (Input.GetKey (KeyCode.D))
		{
			MoveRight ();
		}
			
		Debug.Log (lifeP2);

		if (lifeP2 > 4)
		{
			lifeP2= 5;
		}
	}


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards"))
		{	
			
//			grab ("z", otherObj, player2);
		}

	}


	//	public void duck ()
	//	{
	//		//gameObject.GetComponent<Collider2D> ("Box Collider 2D").isTrigger = false;
	//
	//	}

}
