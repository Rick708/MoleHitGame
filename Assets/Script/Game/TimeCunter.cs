using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCunter : MonoBehaviour
{
    public GameObject MolePrefab;
    public float countdown = 12f;
    public Text timeText;
    public GameObject GameSystem;
    public GameObject StopButton;
    public GameObject ReStartButton;
    public GameObject ScoreCunter;

    bool StartTime;
    public bool StopTime;

    //計測開始
    public void OnStartButton()
    {
        StartTime = true;
        StopTime = false;
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
    public void TimeStopButton()
    {
        StopTime = true;
        ReStartButton.SetActive(true);
        StopButton.SetActive(false);
        MoleManager moleManager = MolePrefab.GetComponent<MoleManager>();
        BoxCollider component = this.gameObject.GetComponent<BoxCollider>();
        Destroy(component);
    }

    //止めた時間を進める
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
        timeText.text = "残り時間" + countdown.ToString("f1") + "秒";

        if (StopTime == true)
        {
            timeText.text = "ポーズ";
            Time.timeScale = 0f;
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
        enabled = false;
        timeText.text = "タイムアップ！！";
        GameSystem Gamestop = GameSystem.GetComponent<GameSystem>();
        Gamestop.GameStop();
        ScoreCunter Scorestop = ScoreCunter.GetComponent<ScoreCunter>();
        Scorestop.ScoreStop();
    }
}
