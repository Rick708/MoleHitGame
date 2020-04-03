using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCunter : MonoBehaviour
{
    public Text score;
    public GameObject TimeCunter;
    int MyScore = 0;

    void Update()
    {
        score.text = ("score:" + MyScore + "点");
    }

    public void AddScore(int add)
    {
            MyScore += add;
    }
}

//時間は０の時は点数が入らない様にしたい
//これは、もぐらを消すことによって実装するか時間切れの時にAddScoreを止める