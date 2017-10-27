using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackFore : MonoBehaviour
 {

	
	//public Transform farEnd;
 	//private Vector3 frometh;
 	//private Vector3 untoeth;
	//private float secondsForOneLength = 5f;
	public float minimum;
    public float maximum;
    public float duration;
	private float startTime;
	public float test;
	 void Start()
 	{
 		//frometh = transform.position;
 		//untoeth = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
		startTime = Time.time;
		minimum = Random.Range(0.0f, 10.0f);
    	maximum = Random.Range(20.0f, 40.0f);
		duration = Random.Range(0.0f, 10.0f);
		 //farEnd.position;
		
 	}
 
 	void FixedUpdate()
 	{
 	 //transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f,1f, 1f) );
	 float t = (Time.time - startTime) / duration;
     transform.position = new Vector3(Mathf.SmoothStep(minimum, maximum, t), 0.5f, test);
	 //Mathf.PingPong(Time.time/secondsForOneLength, 1f)

	
 	}
}

// public Transform farEnd;
 	// private Vector3 frometh;
 	// private Vector3 untoeth;
	// private Vector3 testeth;
 	// private float secondsForOneLength = 5f;
	// public float moveSpeed;
 
 	// void Start()
 	// {
 	// 	frometh = transform.position;
 	// 	untoeth = farEnd.position;
	// 	testeth = new Vector3(Random.Range(-360.0f, 360.0f), 0, 0);
	// 	//Random.Range(-10.0f, 10.0f)
	// 	movePlease();
		
 	// }
 
	// void movePlease()
	// {
 	// 	//transform.LookAt(testeth);
	// 	//transform.position = Vector3.Lerp(frometh, testeth, 
	// 	//transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f,1f,Mathf.PingPong(Time.time/secondsForOneLength, 1f));
	// 	transform.Translate(Vector3.Lerp(frometh, untoeth, moveSpeed*Time.deltaTime));
	// }	

	//transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f,1f,Mathf.PingPong(Time.time/secondsForOneLength, 1f));
