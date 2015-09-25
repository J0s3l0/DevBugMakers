using UnityEngine;
using System.Collections;

public class asteroid : MonoBehaviour {

    private int cont = 0;
    private int posX = 0;
    private int posZ = 0;
    public Transform asteroid1;
    public Transform asteroid2;

    // Update is called once per frame
    void Update()
    {
        cont++;
        if (cont%5 == 0 )
        {   
            
                posX = (int)Random.Range(-400, 1050);
                posZ = (int)Random.Range(-1200, 200);
                Instantiate(asteroid1, new Vector3(posX, 200,posZ), transform.rotation);
            
            cont = 0;
        }
      
    }
}
