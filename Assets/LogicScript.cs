using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;

    public Text scoreText;

    public GameObject gameOverScreen;

    public PipeSpawnerScript pipeSpawner;
    public float moveSpeedOffset;
    public float spawnRateOffset;

    // Start is called before the first frame update
    void Start()
    {
        pipeSpawner = GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawnerScript>();
    }

    [ContextMenu("IncreaseScore")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();

        pipeSpawner.moveSpeed += moveSpeedOffset;
        pipeSpawner.spawnRate -= spawnRateOffset;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
