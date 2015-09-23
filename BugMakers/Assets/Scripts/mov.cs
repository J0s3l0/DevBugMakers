using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
	// Update is called once per frame
	void Update () {

		//Nave avanza o retrocede
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, 1.5f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -1.5f));
        }
		//Nave rota sobre su propio eje
        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(transform.position,transform.up, -5.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(transform.position, transform.up, 5.0f);
        }
		//Nave se eleva o desciende
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (new Vector3 (0,0.5f,0));
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (new Vector3 (0,-0.5f,0));
		}
		//Nave se mueve hacia los lados izquierda/derecha
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3 (-0.5f,0,0));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3 (0.5f,0,0));
		}

    }
}
