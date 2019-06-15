using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scoreText;
    private GameObject Player;

    private int score;
    private float timer;

    private void Awake()
    {
        scoreText = GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");

        score = 0;
        timer = 0;
    }

    private void Update()
    {
        if (Player.activeInHierarchy == true)
        {
            timer += Time.deltaTime;
            score = (int)(timer * 10);
            scoreText.text = $"{score}";
        }
    }
}
