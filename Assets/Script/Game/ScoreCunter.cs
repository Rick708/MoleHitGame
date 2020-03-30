using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCunter : MonoBehaviour
{
    public Text score;

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

