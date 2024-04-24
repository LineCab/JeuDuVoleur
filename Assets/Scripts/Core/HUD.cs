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
	[SerializeField] private GameObject moneyText; //On insère l'objet texte qui affiche le nombre d'argent récolté

	public void updateDeathText(int nbDeath){
		deathText.GetComponent<TMP_Text>().text = "Morts : " + nbDeath;
	}
	public void updateMoneyText(int nbMoney){
		moneyText.GetComponent<TMP_Text>().text = "Argents : " + nbMoney + "€";
	}
	public void updateLivesText(int nbLives){
		livesText.GetComponent<TMP_Text>().text = "Vies : " + nbLives;
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
