using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public int yMove;
	public float speed;
	public float maxHeight;
	public float minHeight;
	public float health = 3;

	private Vector2 targetPos;

	public GameObject MoveEffect;
	public GameObject KillEffect;
 
    private GameManager gm;

    private void Start()
    {
        gm = GetComponent<GameManager>();
    }

    void Update()
    {
		Movement();
		Health();
        Clamp();
    }

	private void Health()
	{
		if(health == 0)
		{
            Instantiate(KillEffect, transform.position, Quaternion.identity); //Instantiate particle system KillEffect
			gameObject.SetActive(false);
		}
	}

	private void Movement()
	{
		transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
		{
			targetPos = new Vector2(transform.position.x, transform.position.y + yMove);
			Instantiate(MoveEffect, transform.position, Quaternion.identity);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
		{
			targetPos = new Vector2(transform.position.x, transform.position.y - yMove);
			Instantiate(MoveEffect, transform.position, Quaternion.identity);
		}
	}

    private void Clamp()
    {
        Vector3 clampedPosition = transform.position;

        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minHeight, maxHeight);
        transform.position = clampedPosition;
    }

    public void UpButton() //Up button if position of the player is less than max height
    {
        if(transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yMove);
            Instantiate(MoveEffect, transform.position, Quaternion.identity);
        }
    }
    public void downButton() //Down button if position of the player is greater than minimal height
    {
        if(transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yMove);
            Instantiate(MoveEffect, transform.position, Quaternion.identity);
        }
    }
}
