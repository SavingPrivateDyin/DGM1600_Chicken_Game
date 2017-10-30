using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWander : MonoBehaviour {

	public float moveSpeed;
	public float randomX;
	public float randomZ;
	public float minWaitTime;
	public float maxWaitTime;
	private Vector3 currentRandomPos;
	public Transform Player;
	public Transform Wolf;
	public Transform PenLocation;

	
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
			PickPosition();
		}
	}

	void PickPosition()
	{
		currentRandomPos = new Vector3(Random.Range(-randomX, randomX), 0, Random.Range(-randomZ, randomZ));
		StartCoroutine ( MoveToRandomPos());
 
	}

	IEnumerator MoveToRandomPos()
	{
		float i = 0.0f;
		float rate = 1.0f / moveSpeed;
		Vector3 currentPos = transform.position;
	
		while (i < 1.0f)
		{
			i += Time.deltaTime * rate;
			transform.position = Vector3.Lerp( currentPos, currentRandomPos, i);
			yield return null;
		}
 
		float randomFloat = Random.Range(0.0f,1.0f); // Create %50 chance to wait
		if(randomFloat < 0.5f)
		StartCoroutine ( WaitForSomeTime());
		else
		PickPosition();
	}

	IEnumerator WaitForSomeTime()
	{
		yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
		PickPosition();
	}
}
