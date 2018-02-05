using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointAtCamera : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.rotation = Quaternion.LookRotation (transform.position - target.position);
	}
}
