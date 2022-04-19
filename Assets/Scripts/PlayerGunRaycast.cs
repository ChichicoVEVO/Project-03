using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGunRaycast : MonoBehaviour
{
    [SerializeField] float rayDistance = 60f;
    [SerializeField] LayerMask _hitLayer;
    [SerializeField] int weaponDamage = 10;
    [SerializeField] EnemyHealthAndDeath callTakeDamage;
    AudioSource gunShotSFX;

    private void Awake()
    {
        gunShotSFX = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gunShotSFX.Play(0);
            Debug.Log("Shpopt");
            ShootRay();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
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
    }
}
