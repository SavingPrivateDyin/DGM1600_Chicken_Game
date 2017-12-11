using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiFollow : MonoBehaviour {

	public Transform Player;
	public float moveSpeed = 4.0f;
	public float maxDist = 10.0f;
	public float minDist = 5.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		transform.LookAt(Player);
		
		if (Vector3.Distance(transform.position, Player.position) >= minDist)
		{
			transform.position += transform.forward * moveSpeed * Time.deltaTime;

			if (Vector3.Distance(transform.position, Player.position) <= maxDist)
			{
				//can add functionallity for shooting or something.
			}
		}
	}
}
