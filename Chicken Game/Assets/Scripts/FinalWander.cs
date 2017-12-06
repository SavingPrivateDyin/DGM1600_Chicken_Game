using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalWander : MonoBehaviour {
	
	public float moveSpeed = 10.0f;
	public float rotSpeed = 60.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	public int points = 10;
	public Transform Player;
	public Transform Wolf;
	public Transform PenLocation;
	public Collider other;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		OnTriggerStay(other);
		// if(OnTriggerStay(Collider other) == false)
		// {
		// 	Wander();
		// }
	}

	void Wander(){
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	      
		
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "wall")
		{
			Debug.Log("chicken triggered wall");
			transform.Rotate(turnAround * rotSpeed * Time.deltaTime);
					
		}
		else if (other.gameObject.name == "Player")
		{
			Debug.Log("Player has entered chicken's trigger");
			transform.LookAt(Player);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
		else if (other.gameObject.name == "Wolf")
		{
			Debug.Log("Wolf has entered chicken's trigger");
			transform.LookAt(Wolf);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
		// else{
		// 	StartCoroutine(Wander);
		// 	transform.Rotate(0,Random.Range(0,360),0);
		// 	transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		// 	// Wander();
		// }
	}
	
	void OnCollisionEnter(Collision other)
	{
		
		if(other.gameObject.name == "Player")
		{
			//Destroy(gameObject); 
			ScoreManager.AddPoints(points);
			transform.position = PenLocation.position;
			transform.rotation = PenLocation.rotation;
		}

	}
}
