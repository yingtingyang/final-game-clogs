using UnityEngine;
using System.Collections;

public class Controller : Movement {


	public GameObject obj2 ;
	float boundDist;
	int desc = 0;
	int Hitcount = 0;
	float maxDist;
    void Start()
    {
		
    }
    //	 Update is called once per frame
    void Update()

    {
        //		boundDist = Vector3.Distance(transform.position, obj2.position);
		obj2 = obj2.transform.position as Vector3;
         maxDist = 7;
        if (Vector3.Distance(obj2, transform.position) > maxDist)
        {

            float angle = Mathf.Atan2(transform.position.y, transform.position.x);
            float x_offset = Mathf.Cos(angle) * (maxDist - .75f); //move back from bounds
            float y_offset = Mathf.Sin(angle) * (maxDist - .75f);

            transform.position = new Vector3(x_offset, y_offset, transform.position.z);
        }


        if (Input.GetKey(KeyCode.UpArrow))

        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.DownArrow))

        {
            MoveDown();
        }

        if (Input.GetKey(KeyCode.LeftArrow))

        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow))

        {
            MoveRight();
        }

		if (Input.GetKeyDown (KeyCode.A)) {
			gethit = false;

		} 
		else if (Input.GetKeyUp(KeyCode.A))

        if (Input.GetKey(KeyCode.S))

        {
			gethit = true;
        }

		if (Hitcount == 3) {
			Destroy(gameObject);

		}

    }


    void OnTriggerStay2D(Collider2D other)
    {
		

        if (other.gameObject.tag == "Bound")
        {
            speed = 8;
        }
    }


    void OnTriggerExit2D (Collider2D other)
	{
                if (other.gameObject.tag == "Bound")
                {
                    speed -= 4;
                    Debug.Log("wut");

                    if (speed <= boundBreak)

                    {
                        speed = boundBreak;
                    }
                }
            }
    void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.tag == "hazards" )
        {
			Hitcount++;
			desc -= 5;
			maxDist -= 5;
        }
    }


}
