﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    //BGM関係
    private void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<SoundSystem>().Length;

        if (numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
