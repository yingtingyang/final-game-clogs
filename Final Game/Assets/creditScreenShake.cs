using UnityEngine;
using System.Collections;

public class creditScreenShake : MonoBehaviour
{

    Vector3 initialL;
    Quaternion initialR;

    public float shakeDuration = 0.1f;
    public float magnitude = 0.1f;

    // Use this for initialization
    void Start()
    {
        initialL = transform.position;
        initialR = transform.rotation;
        StartCoroutine("shakeCam");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("shakeCam");
    }


    IEnumerator shakeCam()
    {
        float timeLeft = shakeDuration;
        while (timeLeft > 0)
        {
            transform.position = initialL + Random.insideUnitSphere * magnitude;
            timeLeft -= Time.deltaTime;
            yield return null;
        }

        transform.position = initialL;
        transform.rotation = initialR;
    }
}


