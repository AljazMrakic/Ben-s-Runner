using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    private Text ScoreText;
    private string score;

    void Start()
    {
        ScoreText = GetComponent<Text>();
        score = PlayerPrefs.GetInt("Score", 0).ToString();
        ScoreText.text = $"S C O R E :  {score}";
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("Score");
        ScoreText.text = $"S C O R E :  0";
    }
}
