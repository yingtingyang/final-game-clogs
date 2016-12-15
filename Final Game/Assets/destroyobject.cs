using UnityEngine;
using System.Collections;

public class destroyobject : MonoBehaviour
{
    //GameObject hazards;

    // Use this for initialization
    void Start()
    {

    }
    void OnCollosionEnter2D(Collision2D coll)
    {
        //hazards = GameObject.FindGameObjectsWithTag("hazards");

        if (coll.gameObject.tag == "hazards")
        {
            //Debug.Log("HIT");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
