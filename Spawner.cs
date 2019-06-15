using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject[] EnemyPattern;

	private float timeBtwSpawn;

    public float startSpawnWait = 2f; //wait N seconds to spawn enemies
	public float startTimeBtwSpawn;
	public float decreaseSpawnTime;
	public float minTime = 0.60f;

    void Update()
    {
		Spawn();
    }

	void Spawn()
	{
		if (timeBtwSpawn <= 0)
		{
			int random = Random.Range(0, EnemyPattern.Length);
			Instantiate(EnemyPattern[random], transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;

			if(startTimeBtwSpawn > minTime)
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
