﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSystem : MonoBehaviour
{
    //SE
    public void OnSEButton()
    {
        SESystem.instance.PlaySE(0);
    }

    //Scene移動
    public void OnGameButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnHistoryButton()
    {
        SceneManager.LoadScene("History");
    }
}
