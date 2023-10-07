using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : Player
{
    private Rigidbody2D rig;
    private bool jumping;
    [SerializeField] private List<ParticleSystem> jumpParticles;
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
        Shoot();
        if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            rig.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
            jumping = true;
            for(int i=0; jumpParticles.Count>i; i++)
            {
                jumpParticles[i].Play();
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            anim.SetBool("isJumping", false);
            jumping = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dano"))
        {
            GameController.instance.GameOver();
        }
    }
}
