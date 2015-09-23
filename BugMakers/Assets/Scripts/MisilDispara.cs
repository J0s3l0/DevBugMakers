using UnityEngine;
using System.Collections;

public class MisilDispara : MonoBehaviour
{
    int invert = -1;
    public Rigidbody misil;
    private Rigidbody clonMisil;
    bool armado;
    
    // Use this for initialization
    void Start()
    {
        armado = true;
       
    }
    // Update is called once per frame
    void Update()
    {
        if (armado)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                Vector3 posMIsil = transform.position;
                posMIsil.x = transform.position.x - (float)0.4;
                posMIsil.y = transform.position.y - 2;
                posMIsil.z = transform.position.z;
                Debug.Log(transform.rotation);
                Rigidbody clonMisil = (Rigidbody)Instantiate(misil, posMIsil, transform.rotation);
                
                Camera.main.cullingMask = -1;
                clonMisil.transform.parent = this.gameObject.transform;
                armado = false;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("armado");
        if (col.name == "Arma"){
            armado = true;
        }
    }
}