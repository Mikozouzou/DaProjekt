using UnityEngine;
using System.Collections;

public class Projectile_Script : MonoBehaviour {

    public float speed;
    public float lifetime;
    public Transform canonPosition;
    Rigidbody myRigidbody; 

	// Use this for initialization
	void Start () 
    {
        myRigidbody = GetComponent<Rigidbody>();
        Destroy(this, lifetime);
        //transform.position = canonPosition;

	}
	
	// Update is called once per frame
	void Update () 
    {
        myRigidbody.AddForce(canonPosition.forward * speed);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
