using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour {

	// Use this for initialization
	public Rigidbody enemy;

	public float randNum;
	public float moveSpeed;
	public int isRunning = 1;
	public int numberOfSeconds;

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
		else
		{
			StartCoroutine (Wander());
			// if (isRunning == 1)
			// {
			// 	StartCoroutine (Wander());
			// }
			//transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
	}

	public IEnumerator Wander()
	{
		//isRunning = 0;
		randNum = Random.Range(0.0f, 10.0f);
		yield return new WaitForSeconds(numberOfSeconds);
		gameObject.transform.Translate(randNum * Time.deltaTime, 0, 0);
		
		//gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
		
		//isRunning = 1;
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

// public class RunAway : MonoBehaviour {

// 	// Use this for initialization
// 	public Rigidbody enemy;

// 	public float randNum;
// 	public float moveSpeed;
// 	public int isRunning = 1;
// 	public int numberOfSeconds;

// 	public Transform Player;
// 	public Transform Wolf;
// 	public Transform PenLocation;


// 	// Use this for initialization
// 	void Start () 
// 	{
// 		StartCoroutine (Wander());
// 	}
	
	
			
// 			// if (isRunning == 1)
// 			// {
// 			// 	StartCoroutine (Wander());
// 			// }
// 			//transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
// 	void OnCollisionEnter(Collision other)
// 	{
// 		if(other.gameObject.name == "Player")
// 		{
// 			//Destroy(gameObject); 
// 			//ScoreManager.AddPoints(points);

// 			transform.position = PenLocation.position;
// 			transform.rotation = PenLocation.rotation;
// 		}

// 	}
// 	void OnTriggerStay(Collider other)
// 		{
// 			if (other.gameObject.name == "Player")
// 			{
// 				Debug.Log("Player has entered chicken's trigger");
// 				transform.LookAt(Player);
// 				transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
// 			}
// 			else if (other.gameObject.name == "Wolf")
// 			{
// 				Debug.Log("Wolf has entered chicken's trigger");
// 				transform.LookAt(Wolf);
// 				transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
// 			}
// 			else
// 			{
// 				//isRunning = 0;
// 				randNum = Random.Range(0.0f, 10.0f);
// 				yield return new WaitForSeconds(numberOfSeconds);
// 				gameObject.transform.Translate(randNum * Time.deltaTime, 0, 0);

// 			//gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);		
// 		    //isRunning = 1;
// 			}

	
// }

// 	public IEnumerator Wander()
// 	{
// 		OnTriggerStay(Collider other);
// 		OnCollisionEnter(Collision other);
// 	}
	


