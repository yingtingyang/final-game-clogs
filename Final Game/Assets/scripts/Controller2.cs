 using UnityEngine;
using System.Collections;

public class Controller2 : actions {

	bool duckKey = false;

    void Start()
    {
		lifeP2= 3;

		
    }
    //	 Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.C)) {
			duckKey = true;
		}
		if (Input.GetKeyUp(KeyCode.C)) {
			duckKey = false;
		}


		 
		thrower ("X");
		die();
	

		Mspace ();

        if (Input.GetKey("W"))
        {
            MoveUp();
        }

        if (Input.GetKey("S"))

        {
            MoveDown();
        }

        if (Input.GetKey("A"))

        {
            MoveLeft();
        }

        if (Input.GetKey("D"))

        {
            MoveRight();
        }
			
		Debug.Log (lifeP2);

    }


	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards") || duckKey == true)
		{	

			Debug.Log ("ducked");

		} 

		else if(otherObj.transform.CompareTag ("hazards") || duckKey == false)

		{

			lifeP1--;
			collDetect (otherObj);
			grab ("Z", otherObj);
		}

	}


	public void duck ()
	{
		//gameObject.GetComponent<Collider2D> ("Box Collider 2D").isTrigger = false;

	}

}
