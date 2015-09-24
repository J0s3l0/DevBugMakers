using UnityEngine;
using System.Collections;

public class CamaraNoRota : MonoBehaviour {
	public GameObject target;
	float posX;
	float posZ;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		posX = target.transform.position.x;
		posZ = target.transform.position.z;
		transform.position = new Vector3(posX, transform.position.y, posZ);
		//transform.position = posZ;

	}
}
