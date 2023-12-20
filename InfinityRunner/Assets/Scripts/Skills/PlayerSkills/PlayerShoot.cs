using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Rigidbody2D rig;
    [SerializeField]
    float speed;
    [SerializeField]
    GameObject Explosion;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5f);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dano") || collision.gameObject.layer==3)
        {
            GameObject explosion = Instantiate(Explosion, this.transform.position, this.transform.rotation);
            CameraFallow.instance.isShaking = true;
            Destroy(explosion, 0.3f);
            Destroy(this.gameObject);
        }
        
    }
    void FixedUpdate()
    {
        rig.velocity = Vector2.right * speed;
    }
}
