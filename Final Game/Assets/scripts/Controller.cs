 using UnityEngine;
using System.Collections;

public class Controller : actions {
	
    void Start()
    {
		life = 3;

		
    }
    //	 Update is called once per frame
    void Update()
    {

		 
		thrower ("g");
		die();
	

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
			
		Debug.Log (life);

    }


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards"))
		{	
			life--;
			collDetect (otherObj);
			grab ("f", otherObj);
		}
	}



}
