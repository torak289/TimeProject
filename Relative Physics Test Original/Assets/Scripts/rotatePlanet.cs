using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlanet : MonoBehaviour {
	public GameObject point;
	public float rotationSpeed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.transform.RotateAround (point.transform.position, Vector3.up, 10 * Time.deltaTime * rotationSpeed);
	}
}
