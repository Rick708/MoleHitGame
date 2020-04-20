using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HistorySystem : MonoBehaviour
{
    public Text[] scoreTexts;
    public GameObject RankingButton;
    public GameObject ListButton;
    bool SortChange;

    List<ScoreData> scoreList = new List<ScoreData>();

    //初期
    void Start()
    {
        LoadScoreDate();
        SortChange = true;
        scoreList.Reverse();
        ShowScoreList(scoreList);
    }

    //ランキング表示
    public void ChangeViewRanking()
    {
        SortChange = false;
        scoreList.Sort((a, b) => a.score - b.score);
        scoreList.Reverse();
        ShowScoreList(scoreList);
    }

    //履歴表示
    public void ChangeViewlist()
    {
        SortChange = true;
        scoreList.Sort((a, b) => b.playCount - a.playCount);
        //scoreList.Reverse();
        ShowScoreList(scoreList);
    }

    // セーブデータからリストを生成
    void LoadScoreDate()
    {
        int playCount = PlayerPrefs.GetInt("PLAY_COUNT", -1);
        for (int i = 0; i <= playCount; i++)
        {
            int myScore = PlayerPrefs.GetInt("SCORE" + i, 0);
            string timeData = PlayerPrefs.GetString("TimeData" + i);
            scoreList.Add(new ScoreData(i, myScore, timeData));
        }
    }

    //テキスト表示
    void ShowScoreList(List<ScoreData> list)
    {      
        for (int i = 0; i < scoreTexts.Length; i++)
        {
            if (list.Count <= i)
            {
                scoreTexts[i].text = "--";
            }
            else if(SortChange == true)
            {
                scoreTexts[i].text = "日時:" + list[i].timeData + "、君は" + list[i].score.ToString() + "点だったよ♫";
            }
            else 
            {
                int Rank = i + 1 ;
                scoreTexts[i].text =  Rank + "位は" + list[i].score.ToString() + "点でした！！";
            }
        }
    }


    //SE
    public void OnSEButton()
    {
        SESystem.instance.PlaySE(0);
    }

    //Scene移動
    public void OnGameButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}

public class ScoreData
{
    public int playCount;
    public int score;
    public string timeData;
    public ScoreData(int playCount, int score, string timeData)
    {
        this.playCount = playCount;
        this.score = score;
        this.timeData = timeData;
    }
}