using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public Color deathColor;
    private SpriteRenderer rend;
    public GameObject explosion, panelLose;
    private AudioSource lose;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        lose = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
     
        if (collision.gameObject.CompareTag("Knife"))
        {
            StartGame.isStart = false;
            Destroy(collision.transform.parent.gameObject);
            rend.color = deathColor;

            ContactPoint2D contact = collision.contacts[0];
            Vector3 pos = contact.point;
           GameObject exp = Instantiate(explosion, pos, Quaternion.identity);
            Destroy(exp, 1);
            lose.Play();

            panelLose.SetActive(true);
        }
    }
}
