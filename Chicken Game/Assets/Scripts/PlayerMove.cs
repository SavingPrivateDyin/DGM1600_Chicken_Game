using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 25.00f;
	public float turnSpeed = 100.00f;
	public float jumpHeight = 30.00f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var j = Input.GetAxis("Jump") * Time.deltaTime * jumpHeight;
		var y = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		transform.Translate(0,j,0);
		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
	}
}
