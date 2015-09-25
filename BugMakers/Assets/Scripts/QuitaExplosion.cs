using UnityEngine;
using System.Collections;

public class QuitaExplosion : MonoBehaviour {

    int contador;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (contador > Time.deltaTime * 500)
        {
            Destroy(this.gameObject);
        }
        contador++;
    }
}
