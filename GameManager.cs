using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private GameObject Player;
    private PlayerController playerControl;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerControl = Player.GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        if (!Player.activeInHierarchy)
        {
            StartCoroutine("waitForGameOver", 1.5f); //Start coroutine waitForGameOver 3seconds
        }
    }

    private IEnumerator waitForGameOver(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("GameOver"); //Load GameOver scene
    }

}
