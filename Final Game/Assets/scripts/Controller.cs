 using UnityEngine;
using System.Collections;

public class Controller : actions {


	bool duckKey = false;

    void Start()
    {

		lifeP1 = 3;
		
    }
    //	 Update is called once per frame
    void Update()
    {

		if (Input.GetKeyDown(KeyCode.B)) {
			duckKey = true;
		}
		if (Input.GetKeyUp(KeyCode.B)) {
			duckKey = false;
		}



		thrower ("n");
		die(lifeP1);
	

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
			
		Debug.Log (lifeP1);


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
			grab ("m", otherObj, player1);
			}


	}


	public void duck ()
	{


		//gameObject.GetComponent<Collider2D> ("Box Collider 2D").isTrigger = false;
	}

}
