 using UnityEngine;
using System.Collections;

public class Controller : actions {


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
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow))

        {
            MoveRight();
        }
			


    }


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards"))
		{
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
