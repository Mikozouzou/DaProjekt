using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Mouvement : MonoBehaviour {

    public float speed;
    public float rotationSpeed;
    public bool chooseDeplacement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButton(0))
        {
            chooseDeplacement = !chooseDeplacement;
        }

        if(chooseDeplacement)
        {
            deplacementLateral();
        }

        if (!chooseDeplacement)
        {
            deplacementRotation();
        }
	}

    void deplacementLateral()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        //transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void deplacementRotation()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
