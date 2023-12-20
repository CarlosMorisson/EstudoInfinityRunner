using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{
    public List<GameObject> plataforms = new List<GameObject>();
    private List<Transform> currentPlataforms = new List<Transform>();
    private Transform player;
    private Transform currentPlataformPoint;
    private int plataformIndex;
    public float offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i=0; i<plataforms.Count; i++)
        {
            Transform p =Instantiate(plataforms[i], new Vector2(i*27, Random.Range(-4,2)), transform.rotation).transform;
            currentPlataforms.Add(p);
            offset += 27;
        }
        currentPlataformPoint = currentPlataforms[plataformIndex].GetComponent<Plataform>().finalPoint;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        float distance = player.position.x - currentPlataformPoint.position.x;
        if (distance >= 3)
        {
            Pooling(currentPlataforms[plataformIndex].gameObject);
            plataformIndex++;
            if (plataformIndex > currentPlataforms.Count - 1)
            {
                plataformIndex = 0;
            }
            currentPlataformPoint = currentPlataforms[plataformIndex].GetComponent<Plataform>().finalPoint;
        }
    }
    public void Pooling(GameObject plataform)
    {
        plataform.transform.position = new Vector2(offset,0 -4f);
        offset += 30f;
    }
}
