using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemy : Enemy
{
    [SerializeField] private GameObject bombPrefab;
    [Range(0,10)]
    [SerializeField] private float throwTime;
    float throwCoolDown;
    float actualBar;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float throwCount;
    [SerializeField] private SpriteRenderer ShotBar;
    void Start()
    {
        StartCoroutine(ShotBomb());
    }

    // Update is called once per frame
    void Update()
    {
        throwCoolDown += Time.deltaTime;
        actualBar = throwCoolDown / throwTime;
        ShotBar.drawMode = SpriteDrawMode.Sliced;
        ShotBar.size = new Vector2(actualBar, 1f);
    }
    public IEnumerator ShotBomb()
    {
        while (true)
        {
            throwCoolDown = 0f;
            Instantiate(bombPrefab, firePoint.position, Quaternion.identity);
            EnemyParticles.Play();
            yield return new WaitForSeconds(throwTime);
        }
    }
}
