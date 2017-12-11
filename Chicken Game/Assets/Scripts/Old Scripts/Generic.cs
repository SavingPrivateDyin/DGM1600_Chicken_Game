using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generic : MonoBehaviour {

	// //Position
	// public float posX;
	// public float posY;
	// public float posZ;
	public Vector3 pos;
	// //ROTATION
	// public float rotX;
	// public float rotY;
	// public float rotZ;
	// public float rotW;
	public Quaternion rot;

	//Scale
	// public float x = 1f;
	// public float y = 1f;
	// public float z = 1f;
	public Vector3 scale = new Vector3(1,1,1);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position = new Vector3 (posX,posY,posZ);
		// transform.rotation = new Quaternion (rotX,rotY,rotZ,rotW);
		// transform.localScale = new Vector3 (x,y,z);

		transform.position = pos;
		transform.rotation = rot;
		transform.localScale = scale;
	}
}
