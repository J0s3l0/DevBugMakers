using UnityEngine;
using System.Collections;


public class ExplotaMisil : MonoBehaviour {
    public GameObject explosion;
    public ParticleSystem propulsor;
    float velocidad = 0;
    int vida = 0;
    bool start = false;
    RaycastHit hit;
    int old;
    Transform target;
    ParticleSystem clonPropulsor;

    void Start()
    {
        target = null;
        old = Camera.main.cullingMask;
    }

    void Update()
    {
        if (start)
        {
            
            if (target)
            {
                var rotation = Quaternion.LookRotation(target.position - transform.position);
                if (target.position.magnitude - transform.position.magnitude < 50)
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
                }
                else
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 2);
                }
            }
            vida++;
        }
        if (vida == 300)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        transform.Translate(0, 0, velocidad);
        if (Input.GetKey(KeyCode.Space))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, 200f))
            {
                if (hit.collider.name == "Target")
                {
                    target = hit.transform;
                    Debug.Log(target.name);

                }
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Camera.main.cullingMask = ~(1 << 5);
            transform.parent = null;
            velocidad = 3f;
            start = true;
            Vector3 lel = new Vector3(2, 2.8f, -16);
            clonPropulsor = (ParticleSystem)Instantiate(propulsor, transform.position, transform.rotation);
            clonPropulsor.transform.parent = transform;
            clonPropulsor.transform.localRotation = Quaternion.Euler(0, 180, 0);
            clonPropulsor.transform.localPosition = lel;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
