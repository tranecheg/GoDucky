using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject music;

    private void Start()
    {
        if(GameObject.Find("Audio(Clone)") == null)
        {
        GameObject instObject = Instantiate(music, transform.position, Quaternion.identity)as GameObject;
        DontDestroyOnLoad(instObject);
        }
    }
}
