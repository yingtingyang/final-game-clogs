using UnityEngine;
using System.Collections;

public class objectSpwan : MonoBehaviour
{
    public GameObject[] enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public float heightVariablilty = 10;
    public float speed = 5f;
    
    //public Rigidbody2D rb;
    //public float speed;

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        //rb = GetComponent<Rigidbody2D>();
    }


    void Spawn()
    {
        //Vector3 spawnPos = transform.position + Vector3.up * (Random.value * heightVariablilty - heightVariablilty * .5f);
       for(int shootnumber = 0; shootnumber< 3; shootnumber++)
        {
            // Find a random index between zero and one less than the number of spawn points.
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            int spawnEnemyIndex = Random.Range(0, 3);
            // int spawnPointIndex = Random.
            // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
            GameObject rb = Instantiate(enemy[spawnEnemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation) as GameObject;
            rb.GetComponent<Rigidbody2D>().velocity = Vector2.left * Random.Range(10,20);
            //rb.GetComponent<Rigidbody2D>().transform.Rotate(Vector3.forward);
            
        }

    }
  

}