using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    Camera camera;

    Ray ray; 
    public RaycastHit hit;
    public Vector3 rayTarget;
    
    
    

    void Start()
    {
        camera = GetComponent<Camera>();
        
    }

    void Update()
    {
        ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));                //Origine du ray : 0,0 = coin inférieur gauche de la caméra ; 1,1 = coin supérieur droit ; 0.5,0.5 = centre de la caméra.

        Vector3 rayTarget = transform.TransformDirection(Vector3.forward) * 10000;    //Valeur du rayon qui sera affiché dans le Debug.
        Debug.DrawRay(transform.position, rayTarget, Color.red);                      //Affichage du rayon, qui correspond au ray.
        

        if (Physics.Raycast(ray, out hit, 50))
        {

        }

        
    }
}
