using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//問題点：スタートボタンを押したら時間表示されるが減らない
//    　　止める際にクリックで反応するがボタンを作りそれで反応させたい。

public class TimeCunter : MonoBehaviour
{
    public float countdown = 0f;
    public Text timeText;
    private bool isPose = false;
    public GameObject GameSystem;

    bool IsStart;
    //boolは二つの定義を持つもの

    public void OnStartButton()
    {
        IsStart = true;
    }

    private void Update()
    {
        if (IsStart == true)
        {
            StartTime();
        }
    }

    void StartTime()
    {
        countdown -= Time.deltaTime;

        //Time.deltaTimeはUpdateの中で書くことに意味があるワンフレーム事

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
            //タイムアップと同時にGameSystemに情報をとばず
            timeText.text = "タイムアップ！！";
        }
    }
}

//時間を動かしたい