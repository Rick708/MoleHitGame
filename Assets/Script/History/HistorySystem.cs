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
    List<int> scoreList = new List<int>();

    //初期
    void Start()
    {
        LoadScoreDate();
        SortChange = true;
        ShowScoreList(scoreList);
    }

    //ランキング表示
    public void ChangeViewRanking()
    {
        SortChange = false;
        ShowScoreList(scoreList);
    }

    //履歴表示
    public void ChangeViewlist()
    {
        SortChange = true;
        ShowScoreList(scoreList);
    }

    // セーブデータからリストを生成
    void LoadScoreDate()
    {
        //string datetimeString = PlayerPrefs.GetString("key");
        //System.DateTime datetime = System.DateTime.FromBinary(System.Convert.ToInt64(datetimeString));

        int playCount = PlayerPrefs.GetInt("PLAY_COUNT", -1);

        for (int i = 0; i <= playCount; i++)
        {
            int myScore = PlayerPrefs.GetInt("SCORE" + i, 0);
            scoreList.Add(myScore);
            
        }
    }

    //テキスト表示
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
                //scoreTexts[i].text = System.ToInt() + "あなたは" + list[i].ToString() + "点だったよ♫";
            }
            else 
            {
                scoreList.Sort();
                scoreList.Reverse();
                //Rank = higher.Count(scoreList) + 1;
                //scoreList.Add(Rank);

                scoreTexts[i].text =  "位は" + list[i].ToString() + "点でした！！";
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
