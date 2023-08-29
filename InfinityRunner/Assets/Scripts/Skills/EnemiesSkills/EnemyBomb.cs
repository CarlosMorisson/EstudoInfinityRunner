using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomb : ShootProjectile
{
    [SerializeField] ParticleSystem[] particles;
    private SpriteRenderer sprite;
    void Start()
    {
        Destroy(this.gameObject, 5f);
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(xAxis, yAxis), ForceMode2D.Impulse);
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        rig.velocity = Vector3.zero;
        rig.gravityScale = 0;
        particles[0].Play();
        particles[1].Play();
        sprite=GetComponent<SpriteRenderer>();
        sprite.color=new Color(0,0,0,0);
    }
}
