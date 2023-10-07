using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Componentes de movimentação do player")]
    public float MoveSpeed;
    public float Damage;
    public float JumpForce;
    public float DashForce;
    public Animator anim;
    [Header("Componentes de combate do player")]
    public GameObject PlayerProjectile;
    [SerializeField]
    private Transform FirePoint;
    
    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(PlayerProjectile, FirePoint.position, FirePoint.rotation);
        }
    }
    
}
