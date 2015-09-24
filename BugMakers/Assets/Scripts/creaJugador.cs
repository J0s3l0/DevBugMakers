using UnityEngine;
using System.Collections;

public class creaJugador : MonoBehaviour {
    public static int op = 0;
    public Transform prefab1;
    public Transform prefab2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (op == 1)
        {

        for (int i = 0; i < 1; i++)
        {
            Instantiate(prefab1, new Vector3(469.4584F, 60F, 324F), Quaternion.identity);
        }
            op = 0;
    }
        else if (op == 2)
        {

            for (int i = 0; i < 1; i++)
            {
                Instantiate(prefab2, new Vector3(469.4584F, 60F, 324F), Quaternion.identity);
            }
            op = 0;
        }
    }
	
}
