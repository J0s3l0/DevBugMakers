using UnityEngine;
using System.Collections;


public class ExplotaMisil : MonoBehaviour {
    public GameObject explosion;
    float velocidad = 0;
    void Update()
    {
		transform.Translate(0, 0, velocidad);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.parent = null;
            velocidad = 1.4f;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Debug.Log(gameObject);
        if (other.tag == "Limite")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
