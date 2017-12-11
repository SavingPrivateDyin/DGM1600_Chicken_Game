using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour 
{

	public GameObject pcHealth;
	public Rigidbody enemy;

	public float moveSpeed;

	public Transform Player;

	// public Transform Chicken;
	// public GameObject[] chickens;

	// public GameObject chicken;
	// public GameObject wolf;

	public int damage;
	public float speed = 12.0f;
	public float rotSpeed = 100.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	

	
	// void Start()
	// {
	// 	chickens = GameObject.FindGameObjectsWithTag("Chicken");
	// }

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
			else if (other.gameObject.tag == "wall")
				{
					Debug.Log("chicken triggered wall");
					transform.Rotate(turnAround * rotSpeed * Time.deltaTime);
					
				}
			else
			{
				Wander();
			}
			// else if (other.gameObject.tag == "chickens")
			// 	{
			// 		Debug.Log("Chicken has entered wolf's trigger");
			// 		// gameObject currentChicken = chickens[i];
			// 		// transform.LookAt(chickens[]);
			// 		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
			// 	}
		}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Player")
		{
			
			if(pcHealth != null)
			{
				print("wolf Attacks!");
				pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
			
			}
			
		}
		else if (other.gameObject.tag == "Chicken")
		{
			Destroy(gameObject);
		}

	}
}
