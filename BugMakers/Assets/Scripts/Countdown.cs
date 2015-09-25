using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

    private bool starttime = false;
    public static bool empezo;
    public AudioSource countdownSound;

    void Start()
    {
        empezo = false;
        starttime = true;

        if (starttime == true)
        {
            StartCoroutine("CountDown");
            
        }
    }

    IEnumerator CountDown()
    {
        countdownSound.Play();
        yield return new WaitForSeconds(3);
        empezo = true;
    }

}

