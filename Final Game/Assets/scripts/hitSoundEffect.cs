using UnityEngine;
using System.Collections;


public class hitSoundEffect : MonoBehaviour
{
    public AudioClip hit;
    public AudioSource hitSound;
    // Use this for initialization
    void Start()
    {
        hitSound.clip = hit;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)

    {
        {
            hitSound.PlayOneShot(hit, 1F);
            }

        }

    }
