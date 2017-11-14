using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour 
{

	public GameObject pcHealth;
	public Rigidbody enemy;

	public float moveSpeed;

	public Transform Player;

	public Transform Chicken;

	public GameObject chicken;
	public GameObject wolf;

	public int damage;
	public float speed = 10.0f;
	public float rotSpeed = 60.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	public GameObject[] chickens;

	void Start()
	{
		chickens = GameObject.FindGameObjectsWithTag("Chicken");
	}
	void Update()
	{
		//if (wolf.transform)
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
			else if (other.gameObject.tag == "Chicken")
				{
					//Debug.Log("Chicken has entered wolf's trigger");
					// gameObject currentChicken = chickens[i];
					// transform.LookAt(chickens[]);
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
		}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Player")
		{
			
			//var hit = other.gameObject;
			//var health = hit.GetComponent<PlayerHealth>();
			
			
			if(pcHealth != null)
			{
				print("wolf Attacks!");
				pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
			
			}
			// if(health != null)
			// {
				
			// 	health.TakeDamage(damage);
			
			// }

			if (other.gameObject.tag == "Chicken")
			{
				Destroy(chickens[1]);
			}
		}

	}
}
