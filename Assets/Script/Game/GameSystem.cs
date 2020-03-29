using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{


    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");// 指定したシーンに移動
    }
    public void OnHistoryButton()
    {
        SceneManager.LoadScene("History");
    }
}
