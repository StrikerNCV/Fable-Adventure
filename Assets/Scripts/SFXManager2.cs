using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager2 : MonoBehaviour
{

    public AudioSource readySound;
    public AudioSource selectSound;

    private static bool sfxmanExists;

    // Use this for initialization
    void Start()
    {
        if (!sfxmanExists)
        {
            sfxmanExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {

    }
}

