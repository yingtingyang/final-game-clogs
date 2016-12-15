using UnityEngine;
using System.Collections;

public class enemyDmgP1 : actions
{

	bool duckKey = false;
	Controller life;
    Animator player_1;
    void Start ()
	{
		life = GetComponentInParent<Controller> ();
        player_1 = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.B))
		{
            player_1.Play("dodgeP1");
            duckKey = true;
		}
		if (Input.GetKeyUp (KeyCode.B))
		{
			duckKey = false;
		}

	}

	void  OnTriggerEnter2D (Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag ("hazards") && duckKey == true)
		{	
			life.lifeP1++;
			Debug.Log ("ducked");

		} else if (otherObj.transform.CompareTag ("hazards") && duckKey == false)
			
		{

			life.lifeP1--;
			collDetect (otherObj);

		}


	}
}


