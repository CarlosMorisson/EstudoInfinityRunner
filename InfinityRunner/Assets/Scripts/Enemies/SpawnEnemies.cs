using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public List<GameObject> enemiesList = new List<GameObject>();
    float timer;
    [SerializeField] private float spawnTime;
    private int EnemiesNumber;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }
    void SpawnEnemy()
    {
        EnemiesNumber = Random.Range(0, enemiesList.Count);
        Instantiate(enemiesList[EnemiesNumber], transform.position+new Vector3(0,Random.Range(0,5),0), transform.rotation);
    }
}
