using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	//distance fields
	float travelSp;
	float amtTraveled;
	public Slider distView;

	//countdown fields
	public float timer;
	public Text timerTxt;





	void awake() 
	{

		timer = 100;
	}

	void Update()
	{
		countdown ();
	}





	 void countdown()
	{
		float t = Time.time - timer;

		string mins = Mathf.Abs((int) t / 60).ToString();
		string sec =  Mathf.Abs( t % 60).ToString("f2");
		timerTxt.text = mins + ":" + sec;
	//	Debug.Log (t + "and" + Time.time + "and" + timer);
	}


	public void loadStart()
	{
		SceneManager.LoadScene("Start");
	}

	public void loadGame()
	{
		SceneManager.LoadScene("Basics");
	}

	public void loadCredits()
	{
		SceneManager.LoadScene("Basics");
	}
}
