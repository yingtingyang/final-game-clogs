﻿using UnityEngine;
using System.Collections;

public class scrollBG : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public float tileSizeZ;
    public float t = 1000;
    //private Vector3 startPosition;

    void Start()
    {
        //startPosition = transform.position;
    }

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
        GetComponent<Renderer>().material.color = Color.Lerp(Color.blue, Color.yellow, t);
        //float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        //transform.position = startPosition + Vector3.left * newPosition;
    }
}