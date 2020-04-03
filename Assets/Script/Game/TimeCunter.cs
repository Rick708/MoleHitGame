using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//問題点：スタートボタンを押したら時間表示されるが減らない
//    　　止める際にクリックで反応するがボタンを作りそれで反応させたい。

public class TimeCunter : MonoBehaviour
{
    public float countdown = 5f;
    public Text timeText;
    private bool isPose = false;
    public GameObject GameSystem;
    public GameObject StopButton;
    public GameObject ReStartButton;

    bool StartTime;
    bool StopTime;
    //boolは二つの定義を持つもの

    //計測開始
    public void OnStartButton()
    {
        StartTime = true;
        StopTime = false;
        //ボタンの表示の有無
    }

    //計測継続
    private void Update()
    {
        if (StartTime == true)
        {
            CountDown();
        }
    }

    //時間を止める
    //ここは処理を短縮化できる
    //例；AにTrueかFalseを作りボタンで書き換えるそれをIF文にして処理する
    //カウントダウンの中も同じ様に処理できるはず
    //あとでする
    public void TimeStopButton()
    {
        StopTime = true;
        ReStartButton.SetActive(true);
        StopButton.SetActive(false);
    }
    //時間を進める
    public void TimeStart()
    {
        StopTime = false;
        ReStartButton.SetActive(false);
        StopButton.SetActive(true);
        Time.timeScale = 1f;
    }

    //計測中
    void CountDown()
    {
        //テキスト表示
        timeText.text = "残り時間" + countdown.ToString("f1") + "秒";

        if (StopTime == true)
        {
            timeText.text = "ポーズ中";
            Time.timeScale = 0;
            return;
        }
        else　if(countdown <= 0)
        {
            TimeUp();
        }
        else
        {
            countdown -= Time.deltaTime;
        }
    }

    //計測終わり
     public void TimeUp()
    {
        //タイムアップと同時にGameSystemに情報をとばず
        enabled = false; //これあってんの？uodateを止めたかった。
        timeText.text = "タイムアップ！！";
        GameSystem timestop = GameSystem.GetComponent<GameSystem>();
        timestop.GameStop();        
    }


    //countdown -= Time.deltaTime;

    //Time.deltaTimeはUpdateの中で書くことに意味がある.
    //ワンフレーム事に処理されるUpdateを時間に直してくれる
    //if (StopTime == false)
    //{
    //    if (StopTime　== true)
    //    {
    //        timeText.text = "ポーズ中";
    //        return;
    //    }
    //    else
    //    {
    //        StopTime = false;
    ////    }
    //}
    //if (StopTime)
    //{
    //    timeText.text = "ポーズ中";
    //    return;
    //}

    //テキスト表示
    //timeText.text = "残り時間" + countdown.ToString("f1") + "秒";

    //計測が終わったら
    //if (countdown <= 0)
    //{
    //    TimeUp();
    //}

}

//時間を止める、ボタン定義してbool使ったif分で行こうかと思う。