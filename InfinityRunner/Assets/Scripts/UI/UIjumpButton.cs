using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIjumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Button JumpButton;
    PlayerMove[] player;
    private bool jumping;

    public void OnPointerDown(PointerEventData eventData)
    {
        jumping = true;
    }
    void Start()
    {
        JumpButton = GetComponent<Button>();
    }
    void Update()
    {
        if(jumping && PlayerMove.instance.JumpCoolDown <1)
        {
            IsJumpingCoolDown();
            PlayerMove.instance.Jump();
        }
        else
        {
            jumping = false;
            JumpCoolDown();
        }
        PlayerMove.instance.JumpBar.fillAmount =  PlayerMove.instance.JumpCoolDown / PlayerMove.instance.JumpCoolDownTotal;
    }
    private float IsJumpingCoolDown()
    {
        PlayerMove.instance.JumpCoolDown += Time.deltaTime;
        
        return PlayerMove.instance.JumpCoolDown;
    }
    private float JumpCoolDown()
    {
        PlayerMove.instance.JumpCoolDown -= Time.deltaTime;
        if (PlayerMove.instance.JumpCoolDown <= 0)
        {
            PlayerMove.instance.JumpCoolDown = 0;
        }
            return PlayerMove.instance.JumpCoolDown;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        jumping = false;
    }
}
