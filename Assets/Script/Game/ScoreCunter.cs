using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCunter : MonoBehaviour
{
    public Text score;
    public GameObject TimeCunter;
    int MyScore = 0;
//    public static List<int> scoreList = new List<int>();
    int playCount;
    //初期
    private void Start()
    {
        //MyScore = PlayerPrefs.GetInt("SCORE", 0);
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
        //scoreList.Add(MyScore);
        PlayerPrefs.SetInt("PLAY_COUNT", playCount);     // 何回目のデータなのか記録
        PlayerPrefs.SetInt("SCORE"+ playCount, MyScore); // スコアを記録
        //PlayerPrefs.Save();

        if (PlayerPrefs.HasKey("SCORE"))
        {
            Debug.Log("OK");

            //objList[0]["Score"] = MyScore;
            //objList[0].SaveAsync();
            /*
            for (int i=0; i<scoreList.Count; i++)
            {
                Debug.Log(i+":"+scoreList[i]);
            }*/
        }
        else
        {
            Debug.Log("NO");
        }
    }
}

//時間は０の時は点数が入らない様にしたい
//これは、もぐらを消すことによって実装するか時間切れの時にAddScoreを止める