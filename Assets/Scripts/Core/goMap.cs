using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goMap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.CompareTag("Player")) {
            col.gameObject.GetComponent<PlayerManager>().FinishLine();
            PlayerManager.SetFreeze(5f);
            SceneManager.LoadScene("Map1");
        }
    }
}
