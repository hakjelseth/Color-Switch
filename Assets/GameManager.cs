using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject ScoreCanvas;
    public scoreBoardText scoreboard;
    public bool restart = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        ScoreCanvas.SetActive(false);
        scoreboard.updateText();
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
