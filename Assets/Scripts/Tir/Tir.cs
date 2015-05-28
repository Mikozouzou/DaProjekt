using UnityEngine;
using System.Collections;

public class Tir : MonoBehaviour {


    CameraScript myCameraScript;
    float distance;

	// Use this for initialization
	void Start ()
    {
        myCameraScript = GameObject.Find("Main Camera").GetComponent<CameraScript>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //ray = new Ray(transform.position, transform.forward);

        distance = Vector3.Distance(transform.position, myCameraScript.hit.point);
        Debug.Log(distance);

        if (distance >= 5)
        {
            transform.LookAt(myCameraScript.hit.point);
            Debug.Log("trololo");
        }
        

        
	}
}
