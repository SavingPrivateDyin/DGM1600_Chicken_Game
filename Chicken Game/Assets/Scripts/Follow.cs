using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour 
{

	public Rigidbody enemy;

	public float moveSpeed;

	public Transform Player;

	public Transform Chicken;

	public int damage;
	public float speed = 10.0f;
	public float rotSpeed = 60.0f;
	Vector3 turnAround = new Vector3(0,1,0);


	void Update()
	{
		Wander();
	}

	void Wander(){
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
	 
	
	
	void OnTriggerStay(Collider other)
		{
			if (other.gameObject.name == "Player")
				{
					//Debug.Log("Player has entered wolf's trigger");
					transform.LookAt(Player);
					transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
				}
			else if (other.gameObject.name == "Chicken")
				{
					//Debug.Log("Chicken has entered wolf's trigger");
					transform.LookAt(Chicken);
					transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
				}
			else if (other.gameObject.tag == "wall")
				{
					Debug.Log("chicken triggered wall");
					transform.Rotate(turnAround * rotSpeed * Time.deltaTime);
					
				}
		}

	void OnCollisionEnter(Collision other)
	{
		// if(other.gameObject.name == "Player"){
		// 	PlayerHealth.TakeDamage(damage);
		// }
		print("wolf Attacks!");
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth>();
		
		if(health != null){
			health.TakeDamage(damage);
			
		}

	}
}
