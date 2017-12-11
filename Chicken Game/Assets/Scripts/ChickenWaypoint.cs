using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenWaypoint : MonoBehaviour {

	public GameObject[] waypoints;
	int currentWP = 0;
	public float speed = 8.0f;
	public float stop = 3.0f;
	public float accuracy = 1.0f;
	public float rotspeed = 4.0f;

	
	void FixedUpdate () {
		StartCoroutine(ChickenWander());
		
	}

	// Coroutine for Wandering chicken
	public IEnumerator ChickenWander() 
	{
		float waitRand = Random.Range(1.0f,3.0f);
		Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);
		Vector3 direction = lookAtGoal - this.transform.position;
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime*rotspeed);

		
		if(direction.magnitude < accuracy)
		{
			// var seconds = waitRand;
			// float waitRand = Random.Range(1.0f,3.0f);
			yield return new WaitForSeconds(waitRand);
			
			currentWP++;
			
			
			// debug.log("going to next waypoint: " + currentWP);
			if(currentWP >= waypoints.Length)
			{
				currentWP = 0;
				
				// debug.log("starting waypoint cycle over at: " + currentWP);
			}
			
		}
		this.transform.Translate(0,0,speed*Time.deltaTime);
		waitRand = Random.Range(1.0f,5.0f);
		
		// if(this.transform.position)
		// yield return null;
	}
}
