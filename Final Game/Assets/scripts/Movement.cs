using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public int speed;

	public Movement()
	{
		speed = 8;
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
		transform.position -= transform.right * Time.deltaTime * speed;
	}	

	public void MoveRight()
	{
		transform.position += transform.right * Time.deltaTime * speed;
	}	

}