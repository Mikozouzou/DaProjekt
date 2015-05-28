using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Deplacement : MonoBehaviour {

    Rigidbody myRigidbody;
    public float jumpValue;
    public float lissageDirection = 15f;    //Cette valeur sert à alonger la vitesse de rotation du personnage
    public float speed;

	// Use this for initialization
	void Start () 
    {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Movement(h, v);
	}

    void Movement( float horizontal, float vertical)
    {
        if (horizontal != 0f || vertical != 0f)     //Si on appuie sur une touche Gauche / Droite ou Haut / Bas
        {
            Rotating(horizontal, vertical);         //On envoie les valeurs des touches de déplacements à la fonction qui va faire diriger le Player
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    void Rotating (float horizontal, float vertical)
    {
        Vector3 targetDirection = new Vector3(horizontal, 0f, 0f);                    //On retranscrit la direction dans laquelle va le joueur avec un Vecteur3 des valeurs des touches appuyées...
        //Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);                    //On retranscrit la direction dans laquelle va le joueur avec un Vecteur3 des valeurs des touches appuyées...
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);   //... puis on utilise LookRotation pour transformer ce Vector3 en Quaternion qui va faire tourner le joueur
        Quaternion newRotation = Quaternion.Lerp(myRigidbody.rotation, targetRotation, lissageDirection * Time.deltaTime);  //On adoucie ensuite la rotation du player en définissant une durée pour faire la rotation
        myRigidbody.MoveRotation(newRotation);          //on effectue ensuite la rotation sur le rigidbody avec les paramètres définis précédemment
    }
}
