using UnityEngine;
using System.Collections;

public class Controller : actions
{
    Animator player_1;

	void Start ()
	{
        player_1 = GetComponent<Animator>();
		lifeP1 = 3;
		otherplayer = GameObject.Find ("player 2").transform;
	}


	void Update ()
	{




		die (lifeP1);
		thrower ("n");

		Mspace ();

		if (Input.GetKey (KeyCode.UpArrow))
		{
			MoveUp ();
            player_1.Play("upP1");
		}

		if (Input.GetKey (KeyCode.DownArrow))
		{
			MoveDown ();
            //player_1.Play("");
        }

		if (Input.GetKey (KeyCode.LeftArrow))
		{
			MoveLeft ();
            player_1.Play("leftP1");
        }

		if (Input.GetKey (KeyCode.RightArrow))
		{
			MoveRight ();
            player_1.Play("rightP1");
        }
			
		Debug.Log (lifeP1);


	}


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards"))
		{	
				
			grab ("m", otherObj, player1);
            player_1.Play("grabP1");
		

		}


	}


	//	public void duck ()
	//	{
	//
	//
	//		//gameObject.GetComponent<Collider2D> ("Box Collider 2D").isTrigger = false;
	//	}

}
