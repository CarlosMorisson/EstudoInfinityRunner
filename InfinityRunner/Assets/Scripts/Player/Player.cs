using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    [Header("Componentes de movimentação do player")]
    public float MoveSpeed;
    public float Damage;
    public float JumpForce;
    public float JumpCoolDownTotal;
    public float JumpCoolDown;
    public float DashForce;
    public Animator anim;
    [Header("Componentes de combate do player")]
    public GameObject PlayerProjectile;
    [SerializeField]
    private Transform FirePoint;
    private float ShootCoolDown;
    [SerializeField]
    private float ShootCoolDownTotal;
    [SerializeField]
    private Image ShotImage;
    public void Shoot()
    {
        if (ShootCoolDown <= 0)
        {
            Instantiate(PlayerProjectile, FirePoint.position, FirePoint.rotation);
            ShootCoolDown = ShootCoolDownTotal;
        }
    }
    void Update()
    {
        ShootCoolDown -= Time.deltaTime;
        if (ShootCoolDown <= 0)
            ShootCoolDown = 0;
        ShotImage.fillAmount =  ShootCoolDown / ShootCoolDownTotal;

    }
}
