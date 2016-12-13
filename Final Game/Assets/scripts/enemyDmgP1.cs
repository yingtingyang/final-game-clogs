using UnityEngine;
using System.Collections;

public class enemyDmgP1 : actions
{

	bool duckKey = false;
	Controller life;

	void Start ()
	{
		life = GetComponentInParent<Controller> ();
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

			Debug.Log ("ducked");

		} else if (otherObj.transform.CompareTag ("hazards") && duckKey == false) {

			life.lifeP1--;
			collDetect (otherObj);

		}


	}
}


