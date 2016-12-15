using UnityEngine;
using System.Collections;

public class destroyobject : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //if(coll.transform.tag == "hazards")
        if (other.transform.CompareTag("hazards"))
        {
            //Debug.Log("HIT");
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
   