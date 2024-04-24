using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	[SerializeField] private float speed = 5f; //Vitesse de rotation
	[SerializeField] private float pause = 0f; //S'il s'arrête un certain nombre de secondes
	[SerializeField] private float angle = 90f; //Au bout de quel angle parcouru il peut marquer une pause	
	
	private int sens = 1;
	private float timer = 0; //timer du temps de pause
	private float timerAngle = 0; //si l'objet marque une pause au bout d'un certain angle, initialisé à la valeur de l'angle, si ça arrive à 0, marque une pause
	private bool angleRectify = false;
	private int cnt = 0;

	// Start is called before the first frame update
	void Start() {
		timerAngle = angle;
		timer = pause;
	}

	// Update is called once per frame
	void FixedUpdate() {
		if(timerAngle == 0 && pause != 0){ 
			if(timer > 0){ //Si le timer est supérieur à 0, on enlève le laps de temps écoulé Time.fixedDeltaTime au timer (sans dépasser 0, grâce à la fonction max)
				timer = Mathf.Max(0, timer - Time.fixedDeltaTime);
			} else { //Si le timer est égal à 0, on réinitialise timerAngle à la valeur de angle et timer à la valeur de pause, on remet angleRectify à false
				timer = pause;
				timerAngle = angle;
				angleRectify = false;
				sens = sens * (-1);
			}
		} else { //Si l'objet n'est pas en pause, on le fait tourner via son transform. On soustrait l'angle parcouru en une frame au timerAngle en valeur absolu pour ne pas dépendre du sens de rotation (sans dépasser 0, grâce à la fonction max)
			transform.Rotate(0, 0, 20 * sens * speed * Time.fixedDeltaTime);
			timerAngle = Mathf.Max(0, timerAngle - Mathf.Abs(20 * sens * speed * Time.fixedDeltaTime));
		}
	}
}
