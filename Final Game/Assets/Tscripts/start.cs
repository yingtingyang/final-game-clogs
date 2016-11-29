using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

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
