using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public int damage = 1;
	public int points = 15;
	public int time = 2;

	// Use this for initialization
	void Start () {
		StartCoroutine(DestroyBullet());
	}
	
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "wolf")
		{
			// Debug.Log("YOU HIT THE WOLF");
			var hit = other.gameObject;
			var health = hit.GetComponent<wolfHealth>();
			// var currentScore = GetComponent<ScoreManager>();
		

			if(health != null)
			{
				health.TakeDamage(damage);
			}
			// if(currentScore != null)
			// {
			// 	ScoreManager.MinusPoints(points);
			// 	Debug.Log("SUBTRACTION POWERS");
			// }
		}
		if(other.gameObject.tag == "chickens")
		{
			// Debug.Log("YOU HIT A CHICKEN");
			var hit = other.gameObject;
			var health = hit.GetComponent<chickenHealth>();
			// var pcHealth = other.gameObject.GetComponent<PlayerHealth>();
			// Debug.Log("Chickens's Health: " + 1);
		

			if(health != null)
			{
				health.TakeDamage(damage);
				
			}
			
		}
	}

	IEnumerator DestroyBullet()
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
	// Update is called once per frame
	void Update () {
		
	}

}
