using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCunter : MonoBehaviour
{
    public Text score;
    public GameObject TimeCunter;
    int MyScore = 0;

    //初期
    private void Start()
    {
        //MyScore = PlayerPrefs.GetInt("SCORE", 0);
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
        PlayerPrefs.SetInt("SCORE", MyScore);
        PlayerPrefs.Save();

        if (PlayerPrefs.HasKey("SCORE"))
        {
            Debug.Log("OK");
            //List[0]["Score"] = MyScore;
            //List[0].SaveAsync();
        }
        else
        {
            Debug.Log("NO");
        }
    }
}

//時間は０の時は点数が入らない様にしたい
//これは、もぐらを消すことによって実装するか時間切れの時にAddScoreを止める