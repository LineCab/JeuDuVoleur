using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlayerOrientation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb; // Le rigidbody pour bouger l'obstacle
    private GameObject player;

    void Start()
    {
        player = PlayerManager.GetPlayer();
    }

    void FixedUpdate()
    {
        // Calculer la direction vers le joueur
        Vector2 direction = (player.transform.position - transform.position).normalized;

        // Orienter l'objet vers le joueur
        transform.right = direction;
    }
}
