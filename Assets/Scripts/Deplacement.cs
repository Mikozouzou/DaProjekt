using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Deplacement : MonoBehaviour {

    Rigidbody myRigidbody;
    public float jumpValue;

	// Use this for initialization
	void Start () 
    {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetMouseButtonDown(0))
        {
            myRigidbody.AddForce(transform.position.x, jumpValue, transform.position.z); 
        }
	}
}
