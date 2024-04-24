using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Vitesse de l'objet, modifiable
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float delay = 0f; // Temps avant de démarrer
    [SerializeField] private float pauseDuration = 2f; // Durée de la pause
    [SerializeField] private float moveDuration = 2f; // Durée du mouvement
    [SerializeField] private GameObject zoneD;
    [SerializeField] private GameObject zoneG;

    private Vector2 movement;
    private bool isMovingRight = false; // Variable pour suivre la direction du mouvement
    private float timer = 0f;

    // Au démarrage, défini la variable de mouvement
    void Start()
    {
        movement = new Vector2(1, 0); // Initialisation du mouvement vers la droite
    }

    // A chaque frame, on bouge l'objet via son rigidbody dans le mouvement défini * la vitesse de l'objet moveSpeed * Time.fixedDeltaTime le laps de temps écoulé en 1 frame
    void FixedUpdate()
    {
        if (delay > 0)
        {
            delay -= Time.fixedDeltaTime;
        }
        else
        {
            timer += Time.fixedDeltaTime; // Incrémente le timer

            // Si le timer dépasse la durée totale (pause + mouvement)
            if (timer >= pauseDuration + moveDuration)
            {
                timer = 0f; 
                isMovingRight = !isMovingRight;
            }

            if (timer < pauseDuration)
            {
                movement = Vector2.zero; 
            }
            else
            {
                if (isMovingRight)
                {
                    movement.x = 1;
                    zoneD.SetActive(true);
                    zoneG.SetActive(false);
                }
                else
                {
                    movement.x = -1;
                    zoneD.SetActive(false);
                    zoneG.SetActive(true);
                }
            }

            // Applique le mouvement
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
