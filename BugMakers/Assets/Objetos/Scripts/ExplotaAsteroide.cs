using UnityEngine;
using System.Collections;


public class ExplotaAsteroide : MonoBehaviour {

    public GameObject explotaAsetroid;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter (Collision coll)
    {
        
        GameObject asteroide = (GameObject) Instantiate(explotaAsetroid, transform.position, Quaternion.identity);
        Destroy(this.gameObject);

    }
}
