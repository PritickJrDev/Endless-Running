using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSound : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject anotherEffect;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(anotherEffect, transform.position, Quaternion.identity);
            SoundScript.PlaySound("birdSoundEffect");
            FindObjectOfType<Player>().health -= 1; //hardcoded
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (QuitScript.gamePaused)
        {
            audioSource.pitch *= .5f;
        }
        else
        {
            audioSource.pitch = 1f;
        }
    }
}
