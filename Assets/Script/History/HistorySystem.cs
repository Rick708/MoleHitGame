using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HistorySystem : MonoBehaviour
{

    public void OnGameButton()
    {
        SceneManager.LoadScene("Game");// 指定したシーンに移動
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}
