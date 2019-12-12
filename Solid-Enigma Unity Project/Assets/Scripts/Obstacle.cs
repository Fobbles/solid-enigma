using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            GameOver.IsGameOver = true;
            Time.timeScale = 0;
        }

    }

    private void Restart()
    {

        if (GameOver.IsGameOver = true && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;

            SceneManager.LoadScene("GameScene");
        }
    }

}
