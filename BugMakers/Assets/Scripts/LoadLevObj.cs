using UnityEngine;
using System.Collections;

public class LoadLevObj : MonoBehaviour {
    // Use this for initialization
     public string level;
    public int opcion;
	public AudioSource audio;
	private int aux=0;
     // Update is called once per frame
	void start()
	{

	}
     public void LoadLevel1(string x)
     {
         Application.LoadLevel(x);
     
	}
    public void op(int a)
    {
        if (a == 1)
        {
            creaJugador.op = 1;
        }

        else if (a == 2)
        {
            creaJugador.op = 2;
        }
    }
}

