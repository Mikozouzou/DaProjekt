using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    Camera camera;

    Ray ray; 
    public RaycastHit hit;
    public Vector3 rayTarget;
    public GameObject bullet;
    public float bulletSpeed;
    public Transform canonPosition;

    void Start()
    {
        camera = GetComponent<Camera>();
        
    }

    void Update()
    {
        ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));                //Origine du ray : 0,0 = coin inférieur gauche de la caméra ; 1,1 = coin supérieur droit ; 0.5,0.5 = centre de la caméra.

        Vector3 rayTarget = transform.TransformDirection(Vector3.forward) * 10000;    //Valeur du rayon qui sera affiché dans le Debug.
        Debug.DrawRay(transform.position, rayTarget, Color.red);                      //Affichage du rayon, qui correspond au ray.
        
        if (Physics.Raycast(ray, out hit, 5))
        {
            Debug.Log("dans la portée");
        }

        if (Input.GetMouseButtonDown(1))
        {
            GameObject instantiatedBullet = Instantiate(bullet, canonPosition.position, transform.rotation) as GameObject;
            instantiatedBullet.GetComponent<Projectile_Script>().canonPosition = canonPosition;
            //instantiatedBullet.transform.position = Vector3.MoveTowards(transform.position, hit.point, step);
            //instantiatedBullet.velocity = new Vector3(0, 0, bulletSpeed);
        }
    }
}
