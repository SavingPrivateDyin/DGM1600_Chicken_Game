using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenWander : MonoBehaviour {

	[SerializeField]
	Transform destination;
	UnityEngine.AI.NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start () {
		navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();

		if(navMeshAgent == null)
		{
			Debug.LogError("The nav mesh agen compenent is not attatched to " + gameObject.name);
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
	
}
