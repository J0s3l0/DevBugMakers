using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
    // Update is called once per frame
    Vector3 nuev = new Vector3(0, 1, 0);
	float speed = 0f;
    void Update () {
		if (Input.GetKey (KeyCode.W)) {
			if(speed < 3.0f)
			   speed += .01f;

			transform.Translate (new Vector3 (0f, 0f, speed));
		} 
		else{
			if(speed >0.0f)
			{speed-= 0.03f;}
			transform.Translate (new Vector3 (0f, 0f, speed));
		}
        if (Input.GetKey(KeyCode.S))
        {
			if(speed > -3.0f)
				speed -= .01f;
            transform.Translate(new Vector3(0f, 0f, speed));
        }
		else{
			if(speed <0.0f)
			{speed+= 0.03f;}
			transform.Translate (new Vector3 (0f, 0f, speed));
		}
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.eulerAngles.x > 345 || transform.eulerAngles.x + 4 < 15)
            {
                transform.RotateAround(transform.position, transform.right, 1.5f);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(this.transform.eulerAngles.x < 15 || transform.eulerAngles.x - 4 > 345)
            {
                transform.RotateAround(transform.position, -transform.right, 1.5f);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(transform.position, nuev, 3.0f);
            if (this.transform.eulerAngles.z > 320|| this.transform.eulerAngles.z < 45)
                transform.RotateAround(transform.position, transform.forward, -1.5f);


        }
        else
        {
            if(transform.eulerAngles.z>315)
            transform.RotateAround(transform.position, transform.forward, +1.5f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(transform.position, nuev, -3.0f);
            if(this.transform.eulerAngles.z > 315 || this.transform.eulerAngles.z < 40)
            transform.RotateAround(transform.position, transform.forward, 1.5f);
        }
        else
        {
            if (transform.eulerAngles.z < 45)
                transform.RotateAround(transform.position, transform.forward, -1.5f);
        }

        //transform.Translate(new Vector3(0f, -.35f, 0f));


    }
}
