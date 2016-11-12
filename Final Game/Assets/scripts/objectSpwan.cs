using UnityEngine;
using System.Collections;

public class objectSpwan : MonoBehaviour
{
    public GameObject[] hazards;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    
    public float heightVariablilty = 10;
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
        Vector3 spawnPos = transform.position + Vector3.up * (Random.value * heightVariablilty - heightVariablilty * .5f);

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(hazards[0], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        
    }


}