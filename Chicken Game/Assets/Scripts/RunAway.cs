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

	[SerializeField]
	Transform destination;
	UnityEngine.AI.NavMeshAgent navMeshAgent;


	// Use this for initialization
	void Start () {
		navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
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
			SetDestination();
		}
	}

	private void SetDestination()
	{
		if(destination !=null)
		{
			Vector3 targetVector = destination.transform.position;
			navMeshAgent.SetDestination(targetVector);
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

		//StartCoroutine (Wander());
			// if (isRunning == 1)
			// {
			// 	StartCoroutine (Wander());
			// }
			//transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);

	// 	public IEnumerator Wander()
	// {
	// 	//isRunning = 0;
	// 	randNum = Random.Range(0.0f, 10.0f);
	// 	yield return new WaitForSeconds(numberOfSeconds);
	// 	gameObject.transform.Translate(randNum * Time.deltaTime, 0, 0);
		
	// 	//gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
		
	// 	//isRunning = 1;
	// }