using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculateDistance : MonoBehaviour {
	bool isTracking;
	private Vector3 distance;
	public Camera arCamera;
	// Update is called once per frame
    void FixedUpdate () {
		distance = arCamera.transform.position - this.transform.localPosition;
    }

    public float getDistance() {
        return distance.magnitude;
    }
}
