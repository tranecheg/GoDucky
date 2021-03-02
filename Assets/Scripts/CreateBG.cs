using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBG : MonoBehaviour
{
    public GameObject now_bg, pref_bg;
    private GameObject new_bg;

    private void Update()
    {
        if (StartGame.isStart)
        {
            if (now_bg.transform.position.x <= -1 && new_bg == null)
                createNewBG();
            else if (new_bg != null && new_bg.transform.position.x <= -1)
                createNewBG();

        }
    }

    private void createNewBG()
    {
        if(now_bg.transform.position.x < -10)
        {
            Destroy(now_bg);
            now_bg = new_bg;
        }
        new_bg = Instantiate(pref_bg, new Vector2(11.5f, -1.33f), Quaternion.identity) as GameObject;
    }
}
