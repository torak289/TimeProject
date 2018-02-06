using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatePlanet : MonoBehaviour {
	public GameObject point;
	private float rotationSpeed = 1;
    private Vector3 dist;
    private float remapDist;
    GameObject imageTarget;
    public Image speedBar;
    public Image speedYears;
    //Start up stuff
	void Start () {
        imageTarget = GameObject.Find("ImageTarget");
	}
    //60Fps Update
	void FixedUpdate () {
        calculateDistance calD = imageTarget.GetComponent<calculateDistance>();
        remapDist = Map(calD.getDistance());
		Debug.Log (remapDist);
		rotationSpeed = 1 * ( Mathf.Exp(remapDist * 2.5f));
		this.transform.RotateAround (point.transform.position, Vector3.up, 10 * Time.deltaTime * rotationSpeed);
	}
    //Max Speed Update
    void Update() {
        speedBar.fillAmount = remapDist;
        speedYears.fillAmount = remapDist;
    }
    //remap number range
    float Map(float value) {
        float min1 = 0; float max1 = 220; float range1 = max1 - min1;
        float min2 = 0; float max2 = 1; float range2 = max2 - min2;

        return value * range2/range1 + min2;
    }
}
