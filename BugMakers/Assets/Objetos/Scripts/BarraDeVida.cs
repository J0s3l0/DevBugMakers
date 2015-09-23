using UnityEngine;
using System.Collections;

public class BarraDeVida : MonoBehaviour {
	public RectTransform healthTransform;
	private float cachedY;
	private float maxValuePos;
	private float minValuePos;
	private int currentHealth;
	public int maxHealth;
	// Use this for initialization
	void Start () {
		maxHealth = 100;
		healthTransform = this.GetComponent<RectTransform>();
		cachedY = healthTransform.position.y;
		maxValuePos = healthTransform.position.x;
		minValuePos = healthTransform.position.x - healthTransform.rect.width;
		currentHealth = maxHealth;

	}


	// Update is called once per frame
	void Update () {
		healthTransform.position = new Vector3(((maxValuePos - minValuePos) / 100) * currentHealth + minValuePos, cachedY);
		if(Input.GetKeyDown(KeyCode.Y))
			currentHealth-=1;
		if(Input.GetKeyDown(KeyCode.U))
			currentHealth+=1;

	}
}
