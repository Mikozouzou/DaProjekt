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

        distance = Vector3.Distance(transform.position, myCameraScript.hit.point); //Calcule la distance entre l'arme et le point de contact du ray de la caméra.

        if (distance >= 5) //Si la distance est supérieure à 5
        {
            transform.LookAt(myCameraScript.hit.point); //Alors l'arme regarde le point d'impact.
        }
        

        
	}
}
