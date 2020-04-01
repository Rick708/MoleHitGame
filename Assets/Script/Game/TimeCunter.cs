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
    public GameObject StopButton;
    public GameObject ReStartButton;
    public GameObject TitleButton;
    public GameObject HistoryButton;

    bool IsStart;
    bool StopTime;
    //boolは二つの定義を持つもの

    //計測開始
    public void OnStartButton()
    {
        IsStart = true;
        StopTime = false;
        //ボタンの表示の有無
    }

    //計測がボタンを押したらに変更
    private void Update()
    {
        if (IsStart == true)
        {
            StartTime();
        }
    }

    //時間を止める
    public void TimeStopButton()
    {
        StopTime = true;
        ReStartButton.SetActive(true);
        StopButton.SetActive(false);
    }

    public void TimeStart()
    {
        StopTime = false;
        ReStartButton.SetActive(false);
        StopButton.SetActive(true);
    }


    void StartTime()
    {
        countdown -= Time.deltaTime;

        //Time.deltaTimeはUpdateの中で書くことに意味があるワンフレーム事

        if (StopTime == false)
        {
            if (StopTime)
            {
                StopTime = true;
            }
            else
            {
                StopTime = false;
            }
        }

        if (StopTime)
        {
            timeText.text = "ポーズ中";
            return;
        }

        timeText.text = "残り時間" + countdown.ToString("f1") + "秒";

        if (countdown <= 0)
        {
            //タイムアップと同時にGameSystemに情報をとばず
            timeText.text = "タイムアップ！！";
            StopButton.SetActive(false);
            TitleButton.SetActive(true);
            HistoryButton.SetActive(true);

        }
    }
}

//時間を止める、ボタン定義してbool使ったif分で行こうかと思う。