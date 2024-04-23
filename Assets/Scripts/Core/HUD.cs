using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
	[SerializeField] private GameObject deathText; //On insère l'objet texte qui affiche le nombre de morts
	[SerializeField] private GameObject levelText; //On insère l'objet texte qui affiche le numéro du niveau
	[SerializeField] private GameObject timerText; //On insère l'objet texte qui affiche le compteur de temps

	[SerializeField] private GameObject livesText; //On insère l'objet texte qui affiche le nombre de vies
	public void updateDeathText(int nbDeath){
		deathText.GetComponent<TMP_Text>().text = "Morts : " + nbDeath;
	}
	public void updateLivesText(int nbLives){
		livesText.GetComponent<TMP_Text>().text = "Vies : " + nbLives;
		// for each life, instantiate a heart
		// for each life lost, destroy a heart
		
		for(int i = 0; i < nbLives; i++){
		}
	}
	
	public void updateLevelText(int numLevel){
		levelText.GetComponent<TMP_Text>().text = "Niveau " + numLevel;
	}
	
	public void updateTimer(float time){
		//Permet d'arrondir le temps à deux chiffres après la virgule
		timerText.GetComponent<TMP_Text>().text = "Temps " + time.ToString("F2")  +"s";
	}
}
