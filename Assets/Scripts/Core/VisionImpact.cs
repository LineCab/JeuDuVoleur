using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionImpact : MonoBehaviour {

    public int Pv = 3;
    [SerializeField] private TableauReinit tableauReinit = null;
    private bool isInCameraZone = false;
    private float timeInCameraZone = 0f;

    void Update() {
        if(isInCameraZone) {
            timeInCameraZone += Time.deltaTime;

            if(timeInCameraZone >= 0.5f) {
                // Si le joueur reste dans la zone de la caméra pendant au moins 0.5 seconde
                if(tableauReinit != null){
                    tableauReinit.Reinit();
                }

                // Réinitialiser la position du joueur
                gameObject.transform.position = TableauManager.GetCheckpointPosition();

                // Ajouter une mort au compteur
                GetComponent<PlayerManager>().AddDeath();
                GetComponent<PlayerManager>().RemoveLife();

                // Immobiliser le joueur pendant 0.5 seconde
                PlayerManager.SetFreeze(0.5f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            isInCameraZone = true;
            StartCoroutine(ResetTimeInZone());
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            isInCameraZone = false;
            timeInCameraZone = 0f; // Réinitialiser le temps écoulé dans la zone
        }
    }

    IEnumerator ResetTimeInZone() {
        // Attendre une petite fraction de seconde pour éviter des incohérences
        yield return new WaitForSeconds(0.1f);

        // Réinitialiser le temps écoulé dans la zone
        timeInCameraZone = 0f;
    }
}
