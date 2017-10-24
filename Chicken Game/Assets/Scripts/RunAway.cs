using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour {

	// Use this for initialization
	public Rigidbody enemy;

	public float moveSpeed;

	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			Debug.Log("Player has entered chicken's trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
	}
}
