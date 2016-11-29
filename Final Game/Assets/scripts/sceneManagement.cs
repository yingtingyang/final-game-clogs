using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneManagement : MonoBehaviour {


	public void StartGameFeedback()
	{
		SceneManager.LoadScene("Start");
	}

	public void StartGameFeedforward()
	{
		SceneManager.LoadScene("Start");
	}

	public void StartGameFeedback()
	{
		SceneManager.LoadScene("Credits");
	}

	public void StartGameFeedforward()
	{
		SceneManager.LoadScene("Credits");
	}

	public void StartGameFeedback()
	{
		SceneManager.LoadScene("Basics");
	}

	public void StartGameFeedforward()
	{
		SceneManager.LoadScene("Basics");
	}

}
