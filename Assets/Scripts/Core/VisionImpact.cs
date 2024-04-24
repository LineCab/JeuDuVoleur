using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionImpact : MonoBehaviour {

    public int Pv = 3;
    [SerializeField] private TableauReinit tableauReinit = null;
    public float x;
	public float y;
	public int numTableau;

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Player") {
            if(tableauReinit != null){
                tableauReinit.Reinit();
            }

            // Appel de la coroutine pour attendre 1 seconde avant de réinitialiser la position du joueur
            StartCoroutine(WaitAndResetPosition(col.gameObject));
        }
    }

    IEnumerator WaitAndResetPosition(GameObject player) {
        // Attendre pendant 1 seconde
        yield return new WaitForSeconds(0.5f);

        // Réinitialiser la position du joueur
        player.GetComponent<PlayerManager>().Teleport(x, y, numTableau);

        // Ajouter une mort au compteur
        player.GetComponent<PlayerManager>().AddDeath();
        player.GetComponent<PlayerManager>().RemoveLife();

        // Immobiliser le joueur pendant 0.5 seconde
        PlayerManager.SetFreeze(0.5f);
    }
}
