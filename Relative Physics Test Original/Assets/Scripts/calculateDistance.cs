using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class calculateDistance : MonoBehaviour {
	bool isTracking;
	Vector3 distance;
	public Camera arCamera;
	// Update is called once per frame
    void FixedUpdate () {
		distance = arCamera.transform.position - this.transform.localPosition;
		Debug.Log ("Distance from camera: " + distance.magnitude);
    }
}
