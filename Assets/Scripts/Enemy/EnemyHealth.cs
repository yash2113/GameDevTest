using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    PlayerHealth playerHealth;
    private Vector3 initialPosition;
    private GameObject enemy;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        initialPosition = transform.position;
    }

    public void DoDamage()
    {
        playerHealth.TakeDamage(20);
    }

    public void ResetEnemy()
    {
        transform.position = initialPosition;
    }
}
