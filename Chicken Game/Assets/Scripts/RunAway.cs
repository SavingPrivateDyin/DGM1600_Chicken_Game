using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour {

	// Use this for initialization
	public Rigidbody enemy;

	public float moveSpeed;

	public Transform Player;
	public Transform Wolf;
	public Transform PenLocation;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name == "Player")
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
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player")
		{
			//Destroy(gameObject); 
			//ScoreManager.AddPoints(points);

			transform.position = PenLocation.position;
			transform.rotation = PenLocation.rotation;
		}

	}
}
