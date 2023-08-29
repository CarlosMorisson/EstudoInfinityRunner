using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemy : Enemy
{
    [SerializeField] private GameObject bombPrefab;
    [Range(0,10)]
    [SerializeField] private float throwTime;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float throwCount;
    void Start()
    {
        StartCoroutine(ShotBomb());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator ShotBomb()
    {
        while (true)
        {
            Instantiate(bombPrefab, firePoint.position, Quaternion.identity);
            EnemyParticles.Play();
            yield return new WaitForSeconds(throwTime);
        }
    }
}
