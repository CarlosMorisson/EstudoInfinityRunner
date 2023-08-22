using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public List<GameObject> enemiesList = new List<GameObject>();
    float timer;
    [SerializeField] private float spawnTime;
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
        Instantiate(enemiesList[0], transform.position+new Vector3(0,Random.Range(0,5),0), transform.rotation);
    }
}
