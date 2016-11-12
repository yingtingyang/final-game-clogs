using UnityEngine;
using System.Collections;

public class detectCollision : MonoBehaviour {

    cameraShake Camera;

    // Use this for initialization
    void Start () {
    

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("hazards"))
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<cameraShake>().startShake();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
