using UnityEngine;
using System.Collections;

public class MisilDispara : MonoBehaviour
{
    public GameObject efecto_escudo;
    public AudioSource shield;
    public AudioSource shieldDown;
    public AudioSource misilSound;
    public AudioSource powerUpSound;
    GameObject escudoP;
    int invert = -1;
    public Rigidbody misil;
    private Rigidbody clonMisil;
    public static bool escudoActivo;
    public static bool armado;
    public static int arma;
    bool cohete;
    bool boost;
    bool escudo;
    bool bomba;
    bool laser;
    bool mina;
    int contador;
                    
                
    // Use this for initialization
    void Start()
    {
        armado = false;
        cohete = false;
       
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.tag == "Player")
        {
            if (escudoActivo)
            {
                contador++;
                //Debug.Log(contador);
                if (contador == 100)
                    shieldDown.Play();
                if (contador > 200)
                {
                    Destroy(escudoP);
                    contador = 0;

                    escudoActivo = false;
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (cohete)
                {
                    Vector3 posMIsil;
                    posMIsil.x = transform.position.x;
                    posMIsil.y = transform.position.y + 5;
                    posMIsil.z = transform.position.z - 15;
                    Debug.Log(transform.rotation);
                    Rigidbody clonMisil = (Rigidbody)Instantiate(misil, posMIsil, transform.rotation);
                    clonMisil.transform.parent = this.gameObject.transform;
                    misilSound.Play();
                    Camera.main.cullingMask = -1;
                    cohete = false;
                    armado = false;
                }

                else if (escudo && !escudoActivo)
                {
                    Debug.Log("se instancio el escudo");
                    escudoP = (GameObject)Instantiate(efecto_escudo, transform.position + new Vector3(0, 3.0f, 0), transform.rotation);
                    shield.Play();
                    escudoP.transform.parent = transform;
                    escudo = false;
                    escudoActivo = true;
                    armado = false;
                }
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("armado");
        
        if (col.tag == "Arma"){
            mov.checkP++;
            if (armado == false)
            {
                powerUpSound.Play();
                arma = (int)Random.Range(0, 2);
                //escudo = true;
                switch (arma)
                {
                    case 0:
                        cohete = true;
                        break;
                    case 1:
                        escudo = true;
                        break;
                    case 2:
                        laser = true;
                        break;
                    case 3:
                        boost = true;
                        break;
                    case 4:
                        bomba = true;
                        break;
                    case 5:
                        mina = true;
                        break;
                }
                armado = true;
            }
            Destroy(col.gameObject);
        }
        
    }
}