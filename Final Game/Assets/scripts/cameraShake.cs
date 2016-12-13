using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour
{

	Vector3 initialL;
	Quaternion initialR;

	public float shakeDuration = 0.1f;
	public float magnitude = 0.1f;

	// Use this for initialization
	void Start ()
	{
		initialL = transform.position;
		initialR = transform.rotation;
	}



	// Update is called once per frame
	void Update ()
	{
	}

	public void startShake ()
	{
		StartCoroutine ("shakeCam");
	}

	IEnumerator shakeCam ()
	{
		float timeLeft = shakeDuration;
		while (timeLeft > 0) {
			transform.position = initialL + Random.insideUnitSphere * magnitude;
			timeLeft -= Time.deltaTime;
			yield return null;
		}

		transform.position = initialL;
		transform.rotation = initialR;
	}
}


