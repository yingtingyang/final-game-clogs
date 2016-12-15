using UnityEngine;
using System.Collections;

public class enemyDmgP2 : actions
{


	bool duckKey = false;
	Controller2 life;

	void Start ()
	{
		life = GetComponentInParent<Controller2> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.C)) {
			duckKey = true;
		}
		if (Input.GetKeyUp (KeyCode.C)) {
			duckKey = false;
		}

	}

	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards") && duckKey == true) {	
			life.lifeP2++;


			Debug.Log ("ducked");

		} else if (otherObj.transform.CompareTag ("hazards") && duckKey == false) {

			life.lifeP2--;
			collDetect (otherObj);

		}


	}
}
