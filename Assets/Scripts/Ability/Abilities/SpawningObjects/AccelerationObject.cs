using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationObject : MonoBehaviour {

    GameObject target;

    float speed;

	void Start () {
        target = GameObject.FindGameObjectWithTag("character");
        speed = target.GetComponent<RootMotionControlScript>().rootMovementSpeed;
        Debug.Log(speed);
    }
	
	// Update is called once per frame
	void Update () {
        
        target.GetComponent<RootMotionControlScript>().rootMovementSpeed = speed + 1f;
    }

    private void OnDestroy()
    {
        target.GetComponent<RootMotionControlScript>().rootMovementSpeed = speed;
    }
}
