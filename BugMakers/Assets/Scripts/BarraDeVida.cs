using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour {
	public RectTransform healthTransform;
	public Image colorBarra;
	private float cachedY;
	private float maxValuePos;
	private float minValuePos;
	private int currentHealth;
	public int maxHealth;
	// Use this for initialization
	void Start () {
		maxHealth = 100;
		healthTransform = this.GetComponent<RectTransform>();
		colorBarra = this.GetComponent<Image> ();
		cachedY = healthTransform.position.y;
		maxValuePos = healthTransform.position.x;
		minValuePos = healthTransform.position.x - healthTransform.rect.width;
		currentHealth = maxHealth;

	}


	// Update is called once per frame
	void Update () {
        currentHealth = mov.vida;
		healthTransform.position = new Vector3(((maxValuePos - minValuePos) / 100) * currentHealth + minValuePos, cachedY);
        if (currentHealth > maxHealth / 2) {
			colorBarra.color= new Color32 (0,120,120, 255);
		} else {
			if(currentHealth> maxHealth/3)
				colorBarra.color = new Color32 (204,204,0, 255);
			else
				colorBarra.color = new Color32 (150,0,75, 255);
		}

	}
}
