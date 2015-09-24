using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ArmaMueve : MonoBehaviour
{
    //public RectTransform armaTransform;
    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite5;
    public Sprite Sprite6;
    private Image actual;
    private int contador = 0;
    private bool cambiado = false;
    // Use this for initialization
    void Start()
    {
        actual = GetComponent<Image>();

    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(contador);
        if (contador >= 0 && contador < Time.deltaTime * 3000)
        {

            if (cambiado == false)
            {
                if (contador < Time.deltaTime * 400)
                {
                    actual.sprite = Sprite1;
                    cambiado = true;
                }
                else if (contador < Time.deltaTime * 900)
                {
                    actual.sprite = Sprite2;
                    cambiado = true;
                }
                else if (contador < Time.deltaTime * 1400)
                {
                    actual.sprite = Sprite3;
                    cambiado = true;
                }
                else if (contador < Time.deltaTime * 1900)
                {
                    actual.sprite = Sprite4;
                    cambiado = true;
                }
                else if (contador < Time.deltaTime * 2400)
                {
                    actual.sprite = Sprite5;
                    cambiado = true;
                }
                else
                {
                    actual.sprite = Sprite6;
                    cambiado = true;
                }
            }
            else
            {
                if (contador > Time.deltaTime * 400 && contador < Time.deltaTime * 500)
                    cambiado = false;
                else if (contador > Time.deltaTime * 900 && contador < Time.deltaTime * 1000)
                    cambiado = false;
                else if (contador > Time.deltaTime * 1400 && contador < Time.deltaTime * 1500)
                    cambiado = false;
                else if (contador > Time.deltaTime * 1900 && contador < Time.deltaTime * 2000)
                    cambiado = false;
                else if (contador > Time.deltaTime * 2400 && contador < Time.deltaTime * 2500)
                    cambiado = false;
            }


        }



        else
        {

            cambiado = false;
            contador = 0;

        }

        contador++;

    }
}
