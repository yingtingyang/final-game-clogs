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




		die (lifeP1);
		thrower ("m");

		Mspace ();

		if (Input.GetKey (KeyCode.UpArrow)) {
			MoveUp ();
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			MoveDown ();
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			MoveLeft ();
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			MoveRight ();
		}
			
		Debug.Log (lifeP1);


	}


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards")) {	
				
			grab ("m", otherObj, player1);
		

		}


	}


	//	public void duck ()
	//	{
	//
	//
	//		//gameObject.GetComponent<Collider2D> ("Box Collider 2D").isTrigger = false;
	//	}

}
