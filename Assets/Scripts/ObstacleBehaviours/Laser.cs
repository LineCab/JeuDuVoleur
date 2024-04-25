using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	// classe qui gère le comportement du laser
	[SerializeField] private float speed = 1f; // vitesse du laser
	// taille de fin du laser
	[SerializeField] private float endSize = 1f;
	// taille de départ du laser
	[SerializeField] private float startSize = 1f;
    // actualiser la taille du laser
    // taille de départ du laser
    [SerializeField] private AudioManager audioManager;

    void Start()
	{
		// taille de laser de 1y 1x 1z
		transform.localScale = new Vector3(1, 1, 0);
        audioManager.PlaySFX(audioManager.laserSFX); //Joue le bruitage de dégâts
    }
	void Update()
	{
		// actualiser la taille du laser
	}
}
