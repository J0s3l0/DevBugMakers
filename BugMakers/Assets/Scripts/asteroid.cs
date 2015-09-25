using UnityEngine;
using System.Collections;

public class asteroid : MonoBehaviour {

    private int cont = 0;
    private int posX = 0;
    private int posZ = 0;
    public Transform asteroid1;
    public Transform asteroid2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cont++;
        if (cont%11 == 0 )
        {   
            for (int i = 0; i < 5; i++)
            {
                posX = (int)Random.Range(200, 4000);
                posZ = (int)Random.Range(-2500, 2400);
                Instantiate(asteroid1, new Vector3(posX, 200,posZ), transform.rotation);
            }
            cont = 0;
        }
      
    }
}
