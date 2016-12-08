 using UnityEngine;
using System.Collections;

public class Controller : actions {
    
    public Animator player_1;

    void awake()
    {
		
    }
    //	 Update is called once per frame
    void Update()
    {
		thrower ("f");

		Mspace ();

        if (Input.GetKey(KeyCode.UpArrow))

        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.DownArrow))

        {
            MoveDown();
        }

        if (Input.GetKey(KeyCode.LeftArrow))

        {
            player_1.Play("leftP1");
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow))

        {
            player_1.Play("rightP1");
            MoveRight();
        }
			


    }


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards"))
		{
            player_1.Play("grabP1");
            grab ("f", otherObj);
        

		}
	}

	void  OnCollisionEnter2D ( Collision2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards"))
		{
			collDetect (otherObj);

		}
	}
}
