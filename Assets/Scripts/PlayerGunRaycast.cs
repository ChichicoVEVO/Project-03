using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunRaycast : MonoBehaviour
{
    [SerializeField] float rayDistance = 60f;
    [SerializeField] float debugRayDuration = 2f;
    [SerializeField] LayerMask _hitLayer;
    [SerializeField] int weaponDamage = 10;
    [SerializeField] EnemyHealthAndDeath callTakeDamage;
    //[SerializeField] AudioSource gunShotSFX;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //gunShotSFX.Play();
            DebugRay();
            ShootRay();
        }
    }

    private void ShootRay()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, rayDistance, _hitLayer))
        {
            Debug.Log("enemy hit");
            callTakeDamage.GetComponent<EnemyHealthAndDeath>().TakeDamage(weaponDamage);
            EnemyHealthAndDeath enemyShooter = hitInfo.transform.gameObject.GetComponent<EnemyHealthAndDeath>();
            enemyShooter?.TakeDamage(weaponDamage);
        }
        else
        {
            Debug.Log("Miss");
        }
    }

    private void DebugRay()
    {
        Vector3 endPoint = transform.forward * rayDistance;
        Debug.DrawRay(transform.position, endPoint, Color.red, debugRayDuration);
    }
}
