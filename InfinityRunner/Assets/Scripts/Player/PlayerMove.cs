using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : Player
{
    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rig.velocity = new Vector2(MoveSpeed,rig.velocity.y);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
