using UnityEngine;
using System.Collections;


public class hitSoundEffect : MonoBehaviour
{
    AudioSource hitSound;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            hitSound.volume = 0F;

        if (Input.GetKeyDown(KeyCode.C))
            hitSound.volume = 0F;

    }

    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }

        }

    }
