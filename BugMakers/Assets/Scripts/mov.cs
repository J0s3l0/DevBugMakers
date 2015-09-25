using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
    // Update is called once per frame
    Vector3 nuev = new Vector3(0, 1, 0);
	float speed = 0f;
    private int vueltas=0;

	public AudioSource turbina;
	public AudioSource turbinaUp;
	public AudioSource turbinaDown;
    public AudioSource choca1;
    public AudioSource choca2;
    public AudioSource choca3;
    public AudioSource finalLap;
    public static int vida;
    public static int turnos = 1;
    public static int checkP = 0;

    private bool turbinaCheck;


    void Awake()
    {
        DontDestroyOnLoad(transform.parent.gameObject);
    }
	
    void Start()
    {
        vida = 100;
    }

    void Update () {

        if (checkP == 10)
        {
            Application.LoadLevel("ganaste");
            checkP = 0;
            Destroy(transform.parent.gameObject, .5f);
        }

        if (Countdown.empezo)
        {
            if (vida <= 0)
            {
                turnos--;
                vida = 100;

            }

            if (turnos == 0 || ControlEnemigo.perdiste)
            {
                turbina.Stop();
                turbinaUp.Stop();
                turbinaDown.Stop();
                choca1.Stop();
                choca2.Stop();
                choca3.Stop();
                finalLap.Stop();
                vida = 100;
                turnos = 1;
                ControlEnemigo.perdiste = false;
                Application.LoadLevel("perdiste");
                Destroy(transform.parent.gameObject, .5f);


            }
            if (Input.GetKey(KeyCode.W))
            {
                if (speed < 3.0f)
                    speed += .01f;

                transform.Translate(new Vector3(0f, 0f, speed));

                if (!turbina.isPlaying && !turbinaUp.isPlaying)
                {
                    turbinaCheck = false;
                    turbinaUp.Play();


                }

                if (turbinaUp.time > 5)
                {
                    turbinaUp.Stop();
                    turbina.Play();
                    turbinaCheck = true;
                }




            }
            else
            {
                turbinaUp.Stop();


                if (!turbinaDown.isPlaying && turbinaCheck)
                {
                    turbinaCheck = false;
                    turbina.Stop();
                    turbinaUp.Stop();
                    turbinaDown.Play();
                }

                if (speed > 0.0f)
                { speed -= 0.03f; }
                transform.Translate(new Vector3(0f, 0f, speed));
            }
            if (Input.GetKey(KeyCode.S))
            {
                if (speed > -3.0f)
                    speed -= .01f;
                transform.Translate(new Vector3(0f, 0f, speed));
            }
            else
            {
                if (speed < 0.0f)
                { speed += 0.03f; }
                transform.Translate(new Vector3(0f, 0f, speed));
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
                if (this.transform.eulerAngles.x < 15 || transform.eulerAngles.x - 4 > 345)
                {
                    transform.RotateAround(transform.position, -transform.right, 1.5f);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.RotateAround(transform.position, nuev, 3.0f);
                if (this.transform.eulerAngles.z > 320 || this.transform.eulerAngles.z < 45)
                    transform.RotateAround(transform.position, transform.forward, -1.5f);


            }
            else
            {
                if (transform.eulerAngles.z > 315)
                    transform.RotateAround(transform.position, transform.forward, +1.5f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.RotateAround(transform.position, nuev, -3.0f);
                if (this.transform.eulerAngles.z > 315 || this.transform.eulerAngles.z < 40)
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


    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.tag);
        if (col.tag == "Teleport")
        {
            if (vueltas < 2)
            {
                transform.position = new Vector3(50F, 5F, -20F);
                transform.Rotate(0, 180, 0);
            }
            vueltas++;

            if (vueltas == 3)
            {
                transform.position = new Vector3(50F, 5F, -20F);
                checkP = 0;
                Application.LoadLevel("nivel2");

            }
            else if (vueltas == 2)
            {
                finalLap.Play();
            }

        }
        else if (col.tag == "Pared")
        {
            speed = 0;
            if (!MisilDispara.escudoActivo)
                vida -= 10;
            int random = Random.Range(0, 3);
            switch (random)
            {
                case 0:
                    choca1.Play();
                    break;
                case 1:
                    choca2.Play();
                    break;
                case 2:
                    choca3.Play();
                    break;
            }


        }
        else if (col.tag == "Cohete")
        {
            if(!MisilDispara.escudoActivo)
            vida -= 10;
        }
    }
   
}




//-1102  Z