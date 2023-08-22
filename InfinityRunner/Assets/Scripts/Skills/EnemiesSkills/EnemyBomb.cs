using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomb : ShootProjectile
{
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(xAxis, yAxis), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
