using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music music;

    private void Awake()
    {
        if(music ==null)
        {
            music = this;
            DontDestroyOnLoad(music);
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
