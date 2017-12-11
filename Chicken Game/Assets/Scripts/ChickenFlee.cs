using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFlee : MonoBehaviour {
	public float speed = 12.0f;
	public Transform Player;
	public Transform Wolf;
	public Transform Chicken;
	public Collider other;
	public Collider capture;
	public int points = 10;
	public Transform PenLocation;
	public Transform spawnPoint;


	// // Use this for initialization
	void Start () {
		var ChickenWaypoint = this.gameObject.GetComponent<ChickenWaypoint>();
            ChickenWaypoint.enabled = true;
	}
	
	
	void OnTriggerStay(Collider other)
	{
		
		if (other.gameObject.name == "Player")
		{
			var ChickenWaypoint = this.gameObject.GetComponent<ChickenWaypoint>();
            ChickenWaypoint.enabled = false;
			Debug.Log("Trigger Enter disables Checkpoint");
			
			Debug.Log("Player has entered chicken's trigger");
			transform.LookAt(Player);
			transform.Translate(Vector3.back.normalized * speed * Time.deltaTime);
			// if (Chicken.position.y <= .5f)
			// {
			// 	transform.Translate(Chicken.position.x, 1, Chicken.position.z);
			// }
		}
		else if (other.gameObject.name == "Wolf")
		{
			var ChickenWaypoint = this.gameObject.GetComponent<ChickenWaypoint>();
            ChickenWaypoint.enabled = false;
			Debug.Log("Wolf has entered chicken's trigger");
			transform.LookAt(Wolf);
			transform.Translate(Vector3.back * speed * Time.deltaTime);
			
		}
		else{
			var ChickenWaypoint = this.gameObject.GetComponent<ChickenWaypoint>();
            ChickenWaypoint.enabled = true;
		}
	}
		

	void OnCollisionEnter(Collision capture)
	{
		
		if(capture.gameObject.name == "Player")
		{
			//Destroy(gameObject); 
			Debug.Log("Player touched the chicken");
			ScoreManager.AddPoints(points);
			transform.position = spawnPoint.position;
			
			// transform.position = PenLocation.position;
			// transform.rotation = PenLocation.rotation;
		}

	}
}
