using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public GameObject Heart1, Heart2, Heart3;
    public GameObject HeartDestroyEffect;

    private GameObject Player;
    private PlayerController playerController;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerController = Player.GetComponent<PlayerController>();
    }

    private void Update()
    {
        switch (playerController.health)
        {
            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;
            case 2:
                Heart1.SetActive(false);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;
            case 1:
                Heart1.SetActive(false);
                Heart2.SetActive(false);
                Heart3.SetActive(true);
                break;
            case 0:
                Heart1.SetActive(false);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;
        }
    }
}
