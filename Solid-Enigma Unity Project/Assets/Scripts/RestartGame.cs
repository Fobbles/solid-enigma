using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Restart();
    }
    private void Restart()
    {

        if (GameOver.IsGameOver && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            GameOver.IsGameOver = false;
            SceneManager.LoadScene("GameScene");
        }
    }

}
