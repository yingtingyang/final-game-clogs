using UnityEngine;
using System.Collections;

public class Controller : Movement {
	
	public Transform obj2;
	public float boundBreak = 1;
	float boundDist;


	void Start() {

  
	}
//	 Update is called once per frame
	void Update () {
//		boundDist = Vector3.Distance(transform.position, obj2.position);

		float maxDist = 7;
		if (Vector3.Distance (Vector3.zero, transform.position) > maxDist) {
			
			float angle = Mathf.Atan2 (transform.position.y, transform.position.x);
			float x_offset = Mathf.Cos (angle) * maxDist;
			float y_offset = Mathf.Sin (angle) * maxDist;

			transform.position = new Vector3 (x_offset, y_offset, transform.position.z);
		}


		if (Input.GetKey (KeyCode.UpArrow)) 

		{
			MoveUp();
		}

		if (Input.GetKey (KeyCode.DownArrow)) 

		{
			MoveDown();
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 

		{
			MoveLeft();
		}

		if (Input.GetKey (KeyCode.RightArrow)) 

		{
			MoveRight();
		}

		if (Input.GetKey (KeyCode.A)) 

		{
			dodge ();
		}

		if (Input.GetKey (KeyCode.S)) 

		{

		}

//		if (boundDist>=8) 
//
//		{
//			 Mathf.Clamp (transform.position.x,0.0f,10.0f);
//		}
//		Debug.Log (boundDist);

	}


	void OnTriggerStay2D (Collider2D other)
	{
		if (other.gameObject.tag == "Bound") 
		{
			speed = 8;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Bound") 
		{
			speed-=4;
			Debug.Log ("wut");

			if (speed <= boundBreak) 

			{
				speed = boundBreak;
			}
		}
	}










	void descend ()
	{




	}


}
