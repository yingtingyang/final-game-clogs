﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

	//distance fields
	public Slider slider;

	//countdown fields
	public float timer;
	public Text timerTxt;

	actions life;

	public Text p2lifeTx;
	public Text p1lifeTx;





	void awake ()
	{ 
		life = GetComponent<actions> ();
		timer = 100;
	}

	void Update ()
	{


		
		travelDist ();
		countdown ();
		playerLives ();

		if (life.lifeP1 <= 0 || life.lifeP2 <= 0)
		{
			Invoke ("GameOver", 3f);
		}
	}





	void countdown ()
	{
		float t = Time.time - timer;

		string mins = Mathf.Abs ((int)t / 60).ToString ();
		string sec = Mathf.Abs (t % 60).ToString ("f2");
		timerTxt.text = mins + ":" + sec;

		//	Debug.Log (t + "and" + Time.time + "and" + timer);
	}

	void travelDist ()
	{
		slider.value = Mathf.MoveTowards (slider.value, slider.maxValue, 0.1f);
	}


	void playerLives()
	{
		string p1life = life.lifeP1.ToString ();	
		string p2life = life.lifeP2.ToString ();	
		p1lifeTx.text = "P1 life:"+ p1life;
		p2lifeTx.text = "P1 life:"+ p2life;

	}


	public void loadStart ()
	{
		SceneManager.LoadScene ("Start");
	}

	public void loadGame ()
	{
		SceneManager.LoadScene ("Basics");
	}

	public void loadCredits ()
	{
		SceneManager.LoadScene ("Credits");
	}


	public void GameOver ()
	{
		
		SceneManager.LoadScene ("GameOver");

	}


    public void instructions()
    {

        SceneManager.LoadScene("Instructions");

    }


}
