using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCunter : MonoBehaviour
{
    public float countdown = 5.0f;
    public Text timeText;
    private bool isPose = false;
    public GameObject StartButton;

    public void OnStartButton()
    {
        StartTime();
    }
    void StartTime()
    {
        countdown -= Time.deltaTime;
        Debug.Log("OK");
        if (Input.GetMouseButtonDown(0))
        {
            if (isPose)
            {
                isPose = false;
            }
            else
            {
                isPose = true;
            }
        }

        if (isPose)
        {
            timeText.text = "ポーズ中";
            return;
        }

        timeText.text = "残り時間" + countdown.ToString("f1") + "秒";

        if (countdown <= 0)
        {
            timeText.text = "タイムアップ！！";
        }
    }
}
