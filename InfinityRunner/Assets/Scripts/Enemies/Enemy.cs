using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rig;
    public float Damage;
    public float Speed;
    public float CoolDown;

    public ParticleSystem EnemyParticles;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerShoot"))
        {
            Destroy(this.gameObject);
        }
    }
}
