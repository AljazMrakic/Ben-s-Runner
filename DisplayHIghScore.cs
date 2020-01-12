using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHIghScore : MonoBehaviour
{
    private Text highScoreText;
    private string highScore;
    
    void Start()
    {
        highScoreText = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("HighScore", 0).ToString();
        highScoreText.text = $"H I G H   S C O R E :  {highScore}";
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScoreText.text = $"H I G H   S C O R E :  0";
    }
}
