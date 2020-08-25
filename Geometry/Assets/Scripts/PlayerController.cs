using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class PlayerController : MonoBehaviour
{
    public float speed = 600f;
    private float movement = 0f;

    private int score;
    public Text scoreText;

    public GameObject gameOverPanel;
    public Text currentScore;
    public Text highScore;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        //if(Input.GetKeyDown(KeyCode.F))
        //    PlayerPrefs.SetInt("Highscore", 0);
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HighscoreUpdate();
        GameOver(PlayerPrefs.GetInt("Highscore", 0));
    }

    public void ScoreUpdate(int scoreValue)
    {
        score += scoreValue;
        scoreText.text = "Score: " + score;
    }

    public int ScoreReturn()
    {
        return score;
    }

    private void GameOver(int highScoreValue)
    {
        gameOverPanel.SetActive(true);
        currentScore.text = "Your score: " + score;
        highScore.text = "Highscore: " + highScoreValue;
        Time.timeScale = 0;
    }

    private void HighscoreUpdate()
    {
        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}

