using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCunter : MonoBehaviour
{
    public Text score;
    public GameObject TimeCunter;
    int MyScore = 0;
    int playCount;

    //初期
    private void Start()
    {
        //ClockText = GetComponentInChildren<Text>();
        playCount = PlayerPrefs.GetInt("PLAY_COUNT", -1);
        playCount++;
    }

    //計測
    void Update()
    {
        score.text = ("score:" + MyScore + "点");
    }

    //加算
    public void AddScore(int add)
    {
        MyScore += add;
    }

    //保存
    public void ScoreStop()
    {
        System.DateTime now = System.DateTime.Now;
        PlayerPrefs.SetString("key", now.ToBinary().ToString());
        PlayerPrefs.SetInt("PLAY_COUNT", playCount);
        PlayerPrefs.SetInt("SCORE"+ playCount, MyScore);
    }
}