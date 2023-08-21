using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform Player;
    [SerializeField] private float speed;
    [SerializeField] private float offset;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void LateUpdate()
    {
        Vector3 newCamPos = new Vector3(Player.position.x + offset, 0f, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newCamPos, speed*Time.deltaTime);
    }
}
