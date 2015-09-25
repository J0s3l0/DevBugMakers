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
        if (MisilDispara.armado== true)
        {
           
            if (MisilDispara.arma == 0)
                actual.sprite = Sprite2;
            else if (MisilDispara.arma == 1)
                actual.sprite = Sprite6;
            contador++;
        }
        else
            actual.sprite = null;
    }
}
