using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject gamOverText;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched Trigger.");
        if (collision.tag == "Player")
        {
            gamOverText.SetActive(true);
            // cue sound effect
            audioSource.Play();
            Debug.Log("The Player Has Touched The Obstical!");
        }
    }
}
