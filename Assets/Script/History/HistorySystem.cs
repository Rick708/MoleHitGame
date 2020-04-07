using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// テキストを取得して、点数を表示
//（Naoyaアイデア） ScoreCounterのScoreからGetComponentでListを取得して、for文で繰り返し表示

// しまづアドバイス：シーンが違うので、オブジェクトは破壊される。ただし、staticは残る
// 
public class HistorySystem : MonoBehaviour
{
    // テキスト等を取得して
    public Text[] scoreTexts;

    List<int> scoreList = new List<int>();

    void Start()
    {
        LoadScoreDate();

        scoreList.Sort();
        scoreList.Reverse();
        ShowScoreList(scoreList);
    }

    // セーブデータからリストを生成
    void LoadScoreDate()
    {
        int playCount = PlayerPrefs.GetInt("PLAY_COUNT", -1);// データの個数-1

        for (int i = 0; i <= playCount; i++)
        {
            int myScore = PlayerPrefs.GetInt("SCORE" + i, 0);
            scoreList.Add(myScore);
        }
    }

    void ShowScoreList(List<int> list)
    {
        
        for (int i = 0; i < scoreTexts.Length; i++)
        {
            if (list.Count <= i)
            {
                scoreTexts[i].text = "-";
            }
            else
            {
                scoreTexts[i].text = list[i].ToString();
            }
        }
    }



    public void OnSEButton()
    {
        SESystem.instance.PlaySE(0);
    }

    public void OnGameButton()
    {
        SceneManager.LoadScene("Game");// 指定したシーンに移動
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}
