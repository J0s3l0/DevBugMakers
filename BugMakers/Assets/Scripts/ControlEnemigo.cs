using UnityEngine;
using System.Collections;

public class ControlEnemigo : MonoBehaviour {
    private int vueltas;
    public static bool perdiste;
    private bool vuelta;
    private int armado;
    private NavMeshAgent agent;
    public Rigidbody misil;
    private Rigidbody clonMisil;

    void Start()
    {
        perdiste = false;
        vueltas = 0;
        armado = 0;
        vuelta = true;
        agent = transform.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        armado++;
        if(armado > 300)
        {
            armado = 0;
            Vector3 posMIsil = transform.position;
            posMIsil.x = transform.position.x - (float)0.4;
            posMIsil.y = transform.position.y - 2;
            posMIsil.z = transform.position.z;
            Rigidbody clonMisil = (Rigidbody)Instantiate(misil, posMIsil, transform.rotation);
            clonMisil.transform.parent = this.gameObject.transform;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.tag);
        if (col.tag == "Teleport" && vuelta)
        {
            vuelta = false;
            if (vueltas < 2)
            {
                agent.enabled = false;
                if (transform.name == "NaveAmarilla")
                {
                    transform.position = new Vector3(0F, 3F, -12F);
                }
                else
                {
                    transform.position = new Vector3(35F, 3F, -12F);
                    transform.Rotate(0, 180, 0);
                }
                vuelta = true;
                agent.enabled = true;
            }
            vueltas++;

            if (vueltas == 3)
            {
                transform.position = new Vector3(50F, 5F, -20F);
                perdiste = true;

            }
        }
    }
        }
