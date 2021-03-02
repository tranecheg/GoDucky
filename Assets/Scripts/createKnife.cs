using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createKnife : MonoBehaviour
{
    public GameObject prefKnife;
    private bool isSpawn;
    private Coroutine spawn;

        private void Update()
    {
        if(StartGame.isStart && !isSpawn)
        {
            spawn = StartCoroutine(spawnKnifes());
            isSpawn = true;
        }
     
    }
    IEnumerator spawnKnifes()
    {
        while (true)
        {
            if (StartGame.isStart)
            {
                Instantiate(prefKnife, new Vector2(6f, Random.Range(-3, 0)),
                    Quaternion.Euler(0, 0, -45));
                
            }
            else
            {
                StopCoroutine(spawn);
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
