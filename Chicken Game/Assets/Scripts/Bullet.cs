using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public int damage = 1;

	public int time = 2;

	// Use this for initialization
	void Start () {
		StartCoroutine(DestroyBullet());
	}
	
	void OnCollisionEnter(Collision other)
	{
		
		var hit = other.gameObject;
		var health = hit.GetComponent<wolfHealth>();
		Debug.Log("Wolf's Health: " + 3);
		

		if(health != null)
		{
			health.TakeDamage(damage);
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
