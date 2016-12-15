using UnityEngine;
using System.Collections;

public class Controller : actions
{


    Animator player_1;
    void Start ()
	{
		
		lifeP1 = 3;
        player_1 = GetComponent<Animator>();
    }


	void Update ()
	{
//		Debug.DrawRay (transform.position, transform.right * 10, Color.green);
//		GrabThrow (player1);
		die (lifeP1);
	

		Mspace ();

		if (Input.GetKey (KeyCode.UpArrow))
		{
            player_1.Play("upP1");
            MoveUp ();
		}

		if (Input.GetKey (KeyCode.DownArrow))
		{
            
            MoveDown ();
		}

		if (Input.GetKey (KeyCode.LeftArrow))
		{
            player_1.Play("leftP1");
            MoveLeft ();
		}

		if (Input.GetKey (KeyCode.RightArrow))
		{
            player_1.Play("rightP1");
            MoveRight ();
		}
			
		Debug.Log (lifeP1);

		
				
			
				
				

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
