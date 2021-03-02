using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBestScore : MonoBehaviour
{
        private void Start()
        {
        GetComponent<Text>().text = "Best score: " + PlayerPrefs.GetInt("score").ToString();
        }
}
