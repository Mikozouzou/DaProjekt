using UnityEngine;
using System.Collections;

public class Saut : MonoBehaviour {

    Rigidbody myRigidbody;
    public float force;
    public float speed;

    float HORIZONTAL;


	// Use this for initialization
	void Start ()
    {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        HORIZONTAL = Input.GetAxis("Horizontal");

        myRigidbody.AddForce(3 * Physics.gravity);
        if(Input.GetMouseButtonDown(1))
        {
            myRigidbody.velocity = new Vector3(0, force, 0);
        }

        if (Input.GetButton("Horizontal"))
        {
            transform.position += transform.right / speed;
        }
	}
}
