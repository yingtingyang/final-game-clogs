using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    public void StartGameFeedback()
    {
        SceneManager.LoadScene("Start");
    }

    public void StartGameFeedforward()
    {
        SceneManager.LoadScene("Start");
    }

}
