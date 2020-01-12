using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPlayerSound : MonoBehaviour
{
    private GameObject Player;
    private PlayerController plycont;

    public AudioSource audioS;

    private bool playing = false;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        plycont = Player.GetComponent<PlayerController>();
    }

    private void Update()
    {
        if(plycont.health == 0 && playing == false)
        {
            audioS.Play();
            playing = true;
        }
    }
}
