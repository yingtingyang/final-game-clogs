using UnityEngine;
using System.Collections;

public class Controller : Movement {
	


	
	// Update is called once per frame
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
			
		}

		if (Input.GetKey (KeyCode.S)) 

		{

		}

		if (Input.GetKey (KeyCode.D)) 

		{

		}



	}
}
