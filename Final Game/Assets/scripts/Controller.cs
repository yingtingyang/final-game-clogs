    using UnityEngine;
using System.Collections;

public class Controller : Movement {
	
	public Transform obj2;
	public float boundBreak = 1;
	float boundDist;
	int desc = -5;

    void Start()
    {
    }
    //	 Update is called once per frame
    void Update()
    {
        //		boundDist = Vector3.Distance(transform.position, obj2.position);

        float maxDist = 7;
        if (Vector3.Distance(Vector3.zero, transform.position) > maxDist)
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

        if (Input.GetKey(KeyCode.L))

        {
            dodge();
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
                    speed -= 0;
                    Debug.Log("wut");

                    if (speed <= boundBreak)

                    {
                        speed = boundBreak;
                    }
                }
            }
    void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.tag == "hazards")
        {
            desc -= 5;
            descend();

        }
    }

	public void descend ()
	{
		obj2.transform.position = new Vector2(0,desc);

    }


}
