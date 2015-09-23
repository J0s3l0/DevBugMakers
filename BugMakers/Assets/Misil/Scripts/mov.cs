using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
    // Update is called once per frame
    Vector3 nuev = new Vector3(0, 1, 0);
    Vector3 regresa;
    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 0f, 0.5f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, 0f, -0.5f));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.eulerAngles.x > 330 || transform.eulerAngles.x + 4 < 30)
            {
                transform.RotateAround(transform.position, transform.right, 1.5f);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(this.transform.eulerAngles.x < 30 || transform.eulerAngles.x - 4 > 330)
            {
                transform.RotateAround(transform.position, -transform.right, 1.5f);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(transform.position, nuev, 3.0f);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(transform.position, nuev, -3.0f);
        }
    }
}
