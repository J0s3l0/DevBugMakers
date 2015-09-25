using UnityEngine;
using System.Collections;

public class rotate_cube : MonoBehaviour {

	public float speed = 10f;

	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collisionInfo)
	{
		print("Detected collision between " + gameObject.name + " and " + collisionInfo.GetComponent<Collider>().name);
		speed += 30f;
	}
}
