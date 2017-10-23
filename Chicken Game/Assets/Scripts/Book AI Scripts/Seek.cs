using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The following is the code for the Seek behaviour
public class Seek : AgentBehaviour {

	public override Steering GetSteering()
	{
		Steering steering = new Steering();
		steering.linear = target.transform.position - transform.position;
		steering.linear.Normalize();
		steering.linear = steering.linear * agent.maxAccel;
		return steering;
	}

}
