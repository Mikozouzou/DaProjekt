using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    Camera camera;

    Ray ray; 
    public RaycastHit hit;

    void Start()
    {
        camera = GetComponent<Camera>();
        
    }

    void Update()
    {
        ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10000;
        Debug.DrawRay(transform.position, forward, Color.red);

        
        if (Physics.Raycast(ray, out hit))
        {
            print("I'm looking at " + hit.transform.name);
        }
        else
        {
            print("I'm looking at nothing!");
        }
            
    }
}
