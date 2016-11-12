﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float speed;

	public bool gethit = true;

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
		transform.position -= transform.right * Time.deltaTime * speed;
	}	

	public void MoveRight()
	{
		transform.position += transform.right * Time.deltaTime * speed;

	}	


	public void dodge ()
	{
		gethit = false;

	}


	public void grab()
	{
		
	}

	public void attack()
	{



	}

		



}