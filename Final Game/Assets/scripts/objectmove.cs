using UnityEngine;
using System.Collections;

public class objectmove : MonoBehaviour {
    public Vector2 velocity = new Vector2(-4, 0);

    void Start()
    {
        GetComponent<Rigidbody2D>();
        velocity =  new Vector2(-4,0);
    }
}
