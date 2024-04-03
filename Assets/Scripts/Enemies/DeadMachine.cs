using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class DeadMachine : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bullet;

    private void Start() {
        InvokeRepeating("BulletSpawnDelay", 1f, 1f);
    }
    void BulletSpawnDelay()
    {
        Instantiate(bullet, firePoint.position, quaternion.identity);
    }
}