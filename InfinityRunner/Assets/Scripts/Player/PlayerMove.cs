using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : Player
{
    private Rigidbody2D rig;
    private bool jumping;
    public static PlayerMove instance;
    [Header ("Efeitos de Pulo")]
    public List<ParticleSystem> jumpParticles;
    public Image JumpBar;
    void Start()
    {
        instance = this;
        rig = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rig.velocity = new Vector2(MoveSpeed,rig.velocity.y);
    }
    public void Jump()
    {
        rig.AddForce(new Vector2(0, JumpForce));
        anim.SetBool("isJumping", true);
        jumping = true;
        for (int i = 0; jumpParticles.Count > i; i++)
        {
            jumpParticles[i].Play();
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
