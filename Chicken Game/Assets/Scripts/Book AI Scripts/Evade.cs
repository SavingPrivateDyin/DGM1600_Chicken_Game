using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade : Flee {

	public float maxPrediciton;
	private GameObject targetAux;
	private Agent targetAgent;

	//Implement the Awake function in order to set up 
	//everything according to the real target
	public override void Awake ()
	{
		base.Awake();
		targetAgent = target.GetComponent<Agent>();
		targetAux = target;
		target = new GameObject();
	}

	public override Steering GetSteering()
	{
		Vector3 direction = targetAux.transform.position - transform.position;
		float distance = direction.magnitude;
		float speed = agent.velocity.magnitude;
		float prediction;
		if (speed <= distance / maxPrediciton)
			prediction = maxPrediciton;
		else 
			prediction = distance / speed;
		
		target.transform.position = targetAux.transform.position;
		target.transform.position += targetAgent.velocity * prediction;
		return base.GetSteering();
	}

	// implement the OnDestroy function, to properly handle the internal object
	void OnDestroy ()
	{
		Destroy(targetAux);
	}
}
