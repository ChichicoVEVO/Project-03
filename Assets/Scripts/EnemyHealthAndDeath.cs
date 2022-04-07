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
            LootMosterDeath();
        }
    }

    public void TakeDamage(int damageAmount)
    {
        Debug.Log("Enemy now has " + health);
        health -= damageAmount;
    }

    private void LootMosterDeath()
    {
        callLootDrops.GetComponent<RandonNumberGenerator>().callLoot();
    }
}
