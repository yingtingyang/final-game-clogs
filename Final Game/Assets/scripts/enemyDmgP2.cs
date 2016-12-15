using UnityEngine;
using System.Collections;

public class enemyDmgP2 : actions
{


	bool duckKey = false;
	Controller2 life;
    Animator player_2;

    void Start ()
	{
		life = GetComponentInParent<Controller2> ();
        player_2 = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.H)) {
           // player_2.Play("dodgeP2");
            duckKey = true;
		}
		if (Input.GetKeyUp (KeyCode.H)) {
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
