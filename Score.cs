using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scoreText;
    private GameObject Player;
    private Spawner spawner;

    private int score;
    private float timer;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");

        score = 0;
        timer = 0;
    }

    private void Update()
    {
        CountScore();
        SetHeighScore();
        SetScore();
    }

    private void CountScore()
    {
        if (Player.activeInHierarchy == true)
        {
            timer += Time.deltaTime;
            score = (int)(timer * 10);
            scoreText.text = $"{score}";
        }
    }

    private void SetHeighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    private void SetScore()
    {
        PlayerPrefs.SetInt("Score", score);
    }
}
