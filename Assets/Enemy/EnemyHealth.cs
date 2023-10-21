using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxhealth = 100;
    int health = 0;

    void Start()
    {
        health = maxhealth;
        Debug.Log(health);
    }
    void OnParticleCollision(GameObject other) 
    {
        health -= 50;
        Debug.Log(health);
        if( health <= 0) 
        {
            Destroy(gameObject);
        }
    }

    
}
