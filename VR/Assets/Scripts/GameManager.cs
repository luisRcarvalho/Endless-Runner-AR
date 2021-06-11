using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvasGameOver;
    void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Replay();
        }
    }

    public void GameOver()
    {
        canvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }


    public static void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
