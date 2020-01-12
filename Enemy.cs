using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public int damage = 1;
	public float speed = 20f;

    //Camera Shake
    public float camShakeAmt = 0.05f;
    public float camShakeLen = 0.1f;
    private CameraShake camShake;


	public GameObject Effect;

	private GameObject Player;
	private PlayerController playerControl;

    private GameObject gm;

	private void Start()
	{
		Player = GameObject.FindGameObjectWithTag("Player"); //Get GameObject Player
		playerControl = Player.GetComponent<PlayerController>(); //Get PlayerController
        gm = GameObject.FindGameObjectWithTag("GameManager");
        camShake = gm.GetComponent<CameraShake>();
	}

	private void Update()
	{
		transform.Translate(Vector2.left * speed * Time.deltaTime); //Move enemy to the left
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Effect, transform.position, Quaternion.identity);

            playerControl.health -= 1; // health -1
            Destroy(gameObject); // Destroy enemy on collison

            //Shake the camera
            camShake.Shake(camShakeAmt, camShakeLen);
        }
    }


}
