using UnityEngine;
using System.Collections;

public class Controller2 : actions
{



    Animator player_2;
    void Start ()
	{
		lifeP2 = 3;
//		otherplayer = GameObject.Find ("player 1").transform;
        player_2 = GetComponent<Animator>();

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
            player_2.Play("upP2");
            MoveUp ();
		}

		if (Input.GetKey (KeyCode.S))
		{
			MoveDown ();
		}

		if (Input.GetKey (KeyCode.A))
		{
            player_2.Play("leftP2");
            MoveLeft ();
		}

		if (Input.GetKey (KeyCode.D))
		{
            player_2.Play("rightP2");
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
