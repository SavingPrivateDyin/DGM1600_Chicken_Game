using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenHealth : MonoBehaviour {

	
	public int maxHealth = 1;
	public int currentHealth = 1;
	public int damage = 1;
	public Transform spawnPoint;
	public int points;
	

	// Use this for initialization

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		// Debug.Log(currentHealth);
		if(currentHealth <= 0)
		{
			currentHealth = 0;
			// print("you killed a chicken!");
			ScoreManager.MinusPoints(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			currentHealth = maxHealth;
		}
	}
}
