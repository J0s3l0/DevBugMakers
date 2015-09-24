using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

    // Use this for initialization
    public string level;

    // Update is called once per frame
   public void LoadLevel1(string x)
    {
        Application.LoadLevel(x);
    }
}
