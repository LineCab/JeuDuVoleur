using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    private float _fireRate;
    private float _canFire = 2f;

    Vector3 _enemyMegaLaserOffset = new Vector3(0f, -5f, 0f);

    [SerializeField] private GameObject _enemyMegaLaserPrefab;

    void Update()
    {
        LaserEnemyFire();
    }
    void LaserEnemiFire()
    {
        if (Time.time > _canFire)
        {

        }
    }
}
