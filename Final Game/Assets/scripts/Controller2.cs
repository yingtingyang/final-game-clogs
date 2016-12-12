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


		 
		thrower ("x");
		die(lifeP2);
	

		Mspace ();

        if (Input.GetKey(KeyCode.W))
        {
            MoveUp();
        }

		if (Input.GetKey(KeyCode.S))

        {
            MoveDown();
        }

		if (Input.GetKey(KeyCode.A))

        {
            MoveLeft();
        }

		if (Input.GetKey(KeyCode.D))

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

			lifeP2--;
			collDetect (otherObj);
			grab ("Z", otherObj,player2);
		}

	}


	public void duck ()
	{
		//gameObject.GetComponent<Collider2D> ("Box Collider 2D").isTrigger = false;

	}

}
