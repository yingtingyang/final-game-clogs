using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {
	int Sp ;

	void Start () {
		Sp = 10;
	}
	
	void Update () {
	

	}

	public void moveUp(){
		transform.Translate (Vector2.up * Sp * Time.deltaTime);
	}
	public void moveDown(){
		transform.Translate (Vector2.down * Sp * Time.deltaTime);
	}
	public void moveLeft(){
		transform.Translate (Vector2.left * Sp * Time.deltaTime);
	}
	public void moveright(){
		transform.Translate (Vector2.right * Sp * Time.deltaTime);
	}
}
