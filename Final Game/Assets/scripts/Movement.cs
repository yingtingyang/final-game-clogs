using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float speed;
	public Transform obj2;
	public float boundBreak = 1;
	float boundDist;

	//camera movement
	cameraShake Camera;

    public Animator player_1;



    public Movement()
	{
		speed = 6;
	}

	public void MoveUp()
	{   
		transform.position += transform.up * Time.deltaTime * speed; 
	}

	public void MoveDown()
	{
		transform.position -= transform.up * Time.deltaTime * speed;
	}	

	public void MoveLeft()
	{
        player_1.Play("leftP1");
        transform.position -= transform.right * Time.deltaTime * speed;
	}	

	public void MoveRight()
	{
        player_1.Play("rightP1");
        transform.position += transform.right * Time.deltaTime * speed;

	}	


	public void Mspace ()
	{
		//		boundDist = Vector3.Distance(transform.position, obj2.position);

		float maxDist = 7;
		if (Vector3.Distance(Vector3.zero, transform.position) > maxDist)
		{
			float angle = Mathf.Atan2(transform.position.y, transform.position.x); //returns polar angle in relation to position
			float x_ratio = Mathf.Cos(angle) * (maxDist - .75f); //converts to polar coordinate of x
			float y_ratio = Mathf.Sin(angle) * (maxDist - .75f); // converts to polar coordinate of y

			transform.position = new Vector3(x_ratio, y_ratio, transform.position.z); //forms a right triangle

		}


	}
		

	public void collDetect(Collider2D otherObj)
	{
		if (otherObj.transform.CompareTag("hazards"))
		{
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<cameraShake>().startShake();
		}


	}



}