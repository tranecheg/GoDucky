using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject logo, score;
    public static bool isStart;
    private float speed = 5f;

   
    public void startGame()
    {
        if (isStart)
            return;
        isStart = true;
        logo.GetComponent<Animator>().enabled = false;
        GetComponent<Animation>().Play("hidePlayButton");
        score.SetActive(true);
    }
    private void Update()
    {
        if (isStart && logo != null)
        {
            logo.transform.Translate(Vector2.up * speed * Time.deltaTime);
            Destroy(logo, 2f);
        }
            
    }
}
