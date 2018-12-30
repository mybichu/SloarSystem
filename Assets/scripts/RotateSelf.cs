using UnityEngine;
using System.Collections;

public class RotateSelf : MonoBehaviour {
    public float angle = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(this.transform.position, Vector3.up, angle);  //行星自转
	}
}
