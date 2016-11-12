using UnityEngine;
using System.Collections;

public class Controller : Movement {
	
	public Transform obj2;
	public float boundBreak = 1;
	float boundDist;

	void Start() {
		 boundDist = Vector3.Distance(transform.position, obj2.position);
	}
//	 Update is called once per frame
	void Update () {


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

		if (Input.GetKey (KeyCode.D)) 

		{

		}

//		if (boundDist == 8) {
//			transform.position.x = Mathf.Clamp (transform.position.x, 0f, 8);
//		
//		}

	}


	void OnTriggerStay2D (Collider2D other)
	{
		if (other.gameObject.tag == "Bound") 
		{
			speed = 6;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Bound") 
		{
			speed-=3;
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
