using UnityEngine;
using System.Collections;

public class destroyobject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
       }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //if(coll.transform.tag == "hazards")
        if (coll.transform.CompareTag("hazards"))
        {
            Debug.Log("HIT");
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
