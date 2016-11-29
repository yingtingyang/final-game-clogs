using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startCredits : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    public void StartGameFeedback()
    {
        SceneManager.LoadScene("Credits");
    }

    public void StartGameFeedforward()
    {
        SceneManager.LoadScene("Credits");
    }

}
