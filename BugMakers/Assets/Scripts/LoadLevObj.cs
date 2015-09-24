using UnityEngine;
using System.Collections;

public class LoadLevObj : MonoBehaviour {
    // Use this for initialization
     public string level;
    public int opcion;
     // Update is called once per frame
     public void LoadLevel1(string x)
     {
       // creaJugador.op = 1;
         Application.LoadLevel(x);
     }
    public void op(int a)
    {
        if(a==1)
        creaJugador.op = 1;
        else if(a==2)
                creaJugador.op = 2;
    }
   
}
