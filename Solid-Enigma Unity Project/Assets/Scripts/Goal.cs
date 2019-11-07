using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detect when the ball enters the goal, and then win the level.
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;

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
            winText.SetActive(true);
            // cue sound effect
            audioSource.Play();
            Debug.Log("The Player Has Entered The Goal!");
        }
    }
}
