using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFollow : MonoBehaviour {

	public Transform target;
	public Transform myTransform;
	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		transform.Translate (Vector3.forward * Time.deltaTime);
	}
}
