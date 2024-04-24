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
		moneyText.GetComponent<TMP_Text>().text = nbMoney + "$";
	}
	public void updateLivesText(int lives){
		livesText.GetComponent<TMP_Text>().text = "Vies : " + lives;
		// for(int i = 0; i < nbLives; i++){
		// }
	}
	
	public void updateLevelText(int numLevel){
		levelText.GetComponent<TMP_Text>().text = "Niveau " + numLevel;
	}
	
	public void updateTimer(float time)
{
    // Convertir le temps en minutes et secondes
    int minutes = Mathf.FloorToInt(time / 60);
    int seconds = Mathf.FloorToInt(time % 60);

    // Mettre en forme le temps en minutes et secondes
    string formattedTime = string.Format("{0:00}:{1:00}", minutes, seconds);

    // Mettre à jour le texte de l'objet TMP_Text
    timerText.GetComponent<TMP_Text>().text = formattedTime;
}


}
