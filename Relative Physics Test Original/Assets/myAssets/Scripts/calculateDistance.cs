using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculateDistance : MonoBehaviour {
	bool isTracking;
	private Vector3 distance;
	public Camera arCamera;

    public LineRenderer lr;
    //60Fps update
    void Awake() {
        lr = (LineRenderer)this.GetComponent(typeof(LineRenderer));
    }
    void Update() {
        Vector3 p = arCamera.ScreenToWorldPoint(new Vector3(arCamera.pixelWidth / 2, 0, arCamera.nearClipPlane));
        lr.SetPosition(0, p);
        lr.SetPosition(1, this.transform.localPosition);
    }
    void FixedUpdate () {
        Color color = new Color(1, 0, 0, 1);
		distance = arCamera.transform.position - this.transform.localPosition;
    }
    //returns distance from camera to target
    public float getDistance() {
        return distance.magnitude;
    }
}
