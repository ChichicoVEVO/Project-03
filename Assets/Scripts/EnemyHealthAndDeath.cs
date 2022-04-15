using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthAndDeath : MonoBehaviour
{
    int health = 100;
    [SerializeField] RandonNumberGenerator callLootDrops;


    private void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
            callLootDrops.GetComponent<RandonNumberGenerator>().callLoot();
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
    }
}
