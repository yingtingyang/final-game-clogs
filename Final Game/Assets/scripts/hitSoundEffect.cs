using UnityEngine;
using System.Collections;


public class hitSoundEffect : MonoBehaviour
{
    public AudioClip hit;
    AudioSource hitSound;
    // Use this for initialization
    void Start()
    {
        hitSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "hazards")
        {
                hitSound.PlayOneShot(hit, 0.7F);
            }

        }

    }
