using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    public static CameraFallow instance;
    private Transform Player;
    [SerializeField] private float speed;
    [SerializeField] private float offset;
    public bool isShaking = false;
    [SerializeField] private float shakeDuration;
    [SerializeField] private float shakeMagnitude;
    private void Start()
    {
        instance = this;
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void LateUpdate()
    {
        Vector3 newCamPos = new Vector3(Player.position.x + offset, 0f, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newCamPos, speed*Time.deltaTime);
        if (isShaking)
        {   
            StartShake(shakeDuration, shakeMagnitude); 
        }
    }
    public void StartShake(float duration, float magnitude)
    {
        shakeDuration = duration;
        shakeMagnitude = magnitude;
        isShaking = false;

    }
}
