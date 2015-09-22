using UnityEngine;
using System.Collections;

public class MisilDispara : MonoBehaviour
{
    public Rigidbody misil;
    private bool instanciado = false;
    private Rigidbody clonMisil;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instanciado = true;
            Vector3 posMIsil = transform.position;
            posMIsil.y -= 2;
			Rigidbody clonMisil = (Rigidbody) Instantiate(misil, posMIsil, transform.rotation);
            clonMisil.transform.parent = this.gameObject.transform;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            clonMisil.transform.parent = null;
        }
    }
}