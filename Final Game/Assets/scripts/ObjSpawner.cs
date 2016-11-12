using UnityEngine;
using System.Collections;

public class ObjSpawner : MonoBehaviour
{
    public Transform objectspawn;
    public float objectspeed = 5;
    Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawnobject", 1f, 1.5f);
    }

    void spawnobject()
    {
        Instantiate(objectspawn);
        rigid.AddForce(Vector3.left * objectspeed);
    }

    void update()
    {
        

    }
    
}
