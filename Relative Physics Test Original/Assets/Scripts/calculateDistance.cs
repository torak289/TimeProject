using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculateDistance : MonoBehaviour {
	bool isTracking;
	private Vector3 distance;
	public Camera arCamera;
	//60Fps update
    void FixedUpdate () {
		distance = arCamera.transform.position - this.transform.localPosition;
    }
    //returns distance from camera to target
    public float getDistance() {
        return distance.magnitude;
    }
}
