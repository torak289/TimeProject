using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlanet : MonoBehaviour {
	public GameObject point;
	private float rotationSpeed = 1;
    private Vector3 dist;
    GameObject imageTarget;
	// Use this for initialization
	void Start () {
        imageTarget = GameObject.Find("ImageTarget");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        calculateDistance calD = imageTarget.GetComponent<calculateDistance>();
        Debug.Log("Distance from camera: " + calD.getDistance());
        rotationSpeed = 1 * (calD.getDistance()/10);
        //Debug.Log("Rotation Speed: " + rotationSpeed);
		this.transform.RotateAround (point.transform.position, Vector3.up, 10 * Time.deltaTime * rotationSpeed);
	}
}
