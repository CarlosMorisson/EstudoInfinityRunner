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
        GameObject particula1= particles[0].gameObject;
        GameObject particula2= particles[1].gameObject;
        GameObject particulaInstanciada1 = Instantiate(particula1, this.transform.position, this.transform.rotation);
        GameObject particulaInstanciada2 = Instantiate(particula2, this.transform.position, this.transform.rotation);
        particulaInstanciada1.GetComponent<ParticleSystem>().Play();
        particulaInstanciada2.GetComponent<ParticleSystem>().Play();
        Destroy(particulaInstanciada1, 1.5f);
        Destroy(particulaInstanciada2, 1.5f);
        Destroy(this.gameObject);
    }
}
