using UnityEngine;
using System.Collections;

public class Controller : Movement {


	public Transform obj2 ;
	float boundDist;
	int desc = 0;
	int Hitcount = 0;
	float maxDist;
	int boundBreak = 2;
	bool gethit = true;
    void Start()
    {
		
    }
    //	 Update is called once per frame
    void Update()

    {
        //		boundDist = Vector3.Distance(transform.position, obj2.position);
         maxDist = 7;
        if (Vector3.Distance(obj2.position, transform.position) > maxDist)
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

		if (Input.GetKeyUp (KeyCode.A))
		
		{
			gethit = true;
		}


        if (Input.GetKey(KeyCode.S))

        {

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
        if (other.gameObject.tag == "hazards" && gethit)
        {
			Hitcount++;
			desc -= 5;
			maxDist -= 5;
        }
		if (gethit) {
			return;
		}
    }


}
