using UnityEngine;
using System.Collections;

public class MisilDispara : MonoBehaviour
{
    public GameObject efecto_escudo;
    GameObject escudoP;
    int invert = -1;
    public Rigidbody misil;
    private Rigidbody clonMisil;
    bool escudoActivo;
    bool armado;
    int arma;
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
        armado = true;
       
    }
    // Update is called once per frame
    void Update()
    {
        if(escudoActivo)
        {
            contador++;
            Debug.Log(contador);
            if(contador > 100)
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


                Vector3 posMIsil = transform.position;
                posMIsil.x = transform.position.x - (float)0.4;
                posMIsil.y = transform.position.y - 2;
                posMIsil.z = transform.position.z;
                Debug.Log(transform.rotation);
                Rigidbody clonMisil = (Rigidbody)Instantiate(misil, posMIsil, transform.rotation);

                Camera.main.cullingMask = -1;
                clonMisil.transform.parent = this.gameObject.transform;
                cohete = false;
            }

            else if (escudo)
            {
                Debug.Log("se instancio el escudo");
                escudoP = (GameObject)Instantiate(efecto_escudo, transform.position + new Vector3(0,5.0f,0), transform.rotation);
                escudoP.transform.parent = transform;
                escudo = false;
                escudoActivo = true;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("armado");
        
        if (col.tag == "Arma"){
            arma = (int)Random.Range(0.0f, 6.0f);
            escudo = true;
            switch(arma)
            {
                case 1:
                    cohete = true;
                    break;
                case 2:
                    boost = true;
                    break;
                case 3:
                    laser = true;
                    break;
                case 4:
                    escudo = true;
                    break;
                case 5:
                    bomba = true;
                    break;
                case 6:
                    mina = true;
                    break;
            }
            
            Destroy(col.gameObject);
        }
        
    }
}