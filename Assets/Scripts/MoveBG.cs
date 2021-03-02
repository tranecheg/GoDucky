using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    
    private float speed = 5f;
    void Update()
    {
        if (StartGame.isStart)
           transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
