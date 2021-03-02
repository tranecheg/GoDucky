﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 targetPos;
    public GameObject player;
    private float speed = 5f;
    void Update()
    {
        if (StartGame.isStart)
        {
#if UNITY_ANDROID
            if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                targetPos = Camera.main.ScreenToWorldPoint(touch.position);
            }
        }
#endif

#if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
#endif
            if (targetPos.y < -3.3f)
                targetPos.y = -3.3f;
            else if (targetPos.y > -0.5f)
                targetPos.y = -0.5f;
            player.transform.position = Vector3.MoveTowards(player.transform.position,
                new Vector3(player.transform.position.x, targetPos.y, player.transform.position.z), 
                speed * Time.deltaTime);
        }
    }


}
