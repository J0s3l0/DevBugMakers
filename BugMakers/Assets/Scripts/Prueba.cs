using UnityEngine;
using System.Collections;

public class Prueba : MonoBehaviour {
    public Rigidbody misil;
    int armado;

    void Start()
    {
        armado = 0;
    }

    void Update()
    {
        armado++;
        if (armado > 150)
        {
            armado = 0;
            Vector3 posMIsil = transform.position;
            posMIsil.x = transform.position.x - (float)0.4;
            posMIsil.y = transform.position.y - 2;
            posMIsil.z = transform.position.z;
            Rigidbody clonMisil = (Rigidbody)Instantiate(misil, posMIsil, transform.rotation);
            clonMisil.transform.parent = this.gameObject.transform;
        }
    }
}
