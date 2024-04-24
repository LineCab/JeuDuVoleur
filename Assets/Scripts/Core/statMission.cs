using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class statMission : MonoBehaviour
{
    [SerializeField] private GameObject timerText;
    [SerializeField] private GameObject moneyText;

    public void updateMoneyText(int nbMoney){
		moneyText.GetComponent<TMP_Text>().text = nbMoney + "$";
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
