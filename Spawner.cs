using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
	public GameObject[] EnemyPattern;

    public Text countDownText;

	private float timeBtwSpawn;
	public float startTimeBtwSpawn;
	public float decreaseSpawnTime;
	public float minTime = 0.60f;
    int rand;

    public float currentTime = 0;
    float startingTime = 3;

    private void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        DecreaseTime();
		Spawn();
    }

    void Spawn()
    {
        if (currentTime == 0)
        {

            if (timeBtwSpawn <= 0)
            {
                rand = Random.Range(0, EnemyPattern.Length);
                Instantiate(EnemyPattern[rand], transform.position, Quaternion.identity);
                timeBtwSpawn = startTimeBtwSpawn;

                if (startTimeBtwSpawn > minTime)
                {
                    startTimeBtwSpawn -= decreaseSpawnTime;
                }
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }
    }

    void DecreaseTime()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            countDownText.gameObject.SetActive(false);
        }
    }
}
