using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// テキストを取得して、点数を表示
// ScoreCounterのScoreからGetComponentでListを取得して、for文で繰り返し表示
public class HistorySystem : MonoBehaviour
{
    // テキスト等を取得して
    public Text[] scoreTexts;
    public GameObject RankingButton;
    public GameObject ListButton;
    bool SortChange;

    List<int> scoreList = new List<int>();

    void Start()
    {
        LoadScoreDate();
        SortChange = true;
        ShowScoreList(scoreList);
    }

    public void ChangeViewRanking()
    {
        SortChange = false;
        ShowScoreList(scoreList);
    }

    public void ChangeViewlist()
    {
        SortChange = true;
        ShowScoreList(scoreList);

    }
    // セーブデータからリストを生成
    void LoadScoreDate()
    {
        
        int playCount = PlayerPrefs.GetInt("PLAY_COUNT", -1);// データの個数-1
        //listnum.Add(playCount);
        
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
                scoreTexts[i].text = "--";
            }
            else if(SortChange == true)
            {
                scoreList.Reverse();
                scoreTexts[i].text =　"お疲れ様でした！！あなたは" + list[i].ToString() + "点だったよ♫";
            }
            else 
            {
                scoreList.Sort();
                scoreList.Reverse();
                scoreTexts[i].text =  "位は" + list[i].ToString() + "点でした！！";
            }
        }
    }



    public void OnSEButton()
    {
        SESystem.instance.PlaySE(0);
    }

    public void OnGameButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}
