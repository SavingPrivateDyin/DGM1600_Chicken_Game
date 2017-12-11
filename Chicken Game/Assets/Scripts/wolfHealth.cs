using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {
	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnPoint;
	public int points;

	// Use this for initialization

	// void Start()
	// {
	// 	StartCoroutine(TakeDamage(damage));
	// }

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		Debug.Log(currentHealth);
		if(currentHealth <= 0)
		{
			currentHealth = 0;
			print("wolf id dead!");
			ScoreManager.AddPoints(points);
			
			transform.position = spawnPoint.position;
			currentHealth = maxHealth;
		}
	}
	
}
