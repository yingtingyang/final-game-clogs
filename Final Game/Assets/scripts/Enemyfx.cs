using UnityEngine;
using System.Collections;

public class Enemyfx : MonoBehaviour {



	//

	void OnTriggerStay(Collider2D otherObj)
	{
		if (Input.GetKeyDown ("c") ) 
		{
			if (otherObj.transform.CompareTag ("Player"))
			{	

				Debug.Log("dodge");

			}
		}
	}
}
