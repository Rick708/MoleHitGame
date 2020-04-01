using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public GameObject MolePrefab;
    GameObject Mole;
    public GameObject TitleButton;
    public GameObject HistoryButton;
    public GameObject StartButton;
    public GameObject TimeCunter;
    

    //初期設定
    void Start()
    {
        TitleButton.SetActive(false);
        HistoryButton.SetActive(false);
    }

    //ゲーム開始
    public void OnStartButton()
    {
        EncountMole();
        StartButton.SetActive(false);
    }

    //モグラ出現

    Vector3[] positions = {
        new Vector3(1, -2, 0),
        new Vector3(3, -2, 0),
        new Vector3(-3, -2, 0),
        new Vector3(5, -2, 0),
        new Vector3(-5, -2, 0),
    };


    void EncountMole()
    {
        for (int i = 0; i < 5; i++)
        {
            Mole = Instantiate(MolePrefab);
            MoleManager moleManager = Mole.GetComponent<MoleManager>();
            int r = Random.Range(0, positions.Length);
            moleManager.transform.position = positions[r];

        }
    }


        void MoleTap()
    {
        Debug.Log("いけた！！");
    }

    //時間切れでボタン表示する
    //そのまま点数を保存する


    //SE
    public void OnSEButton()
    {
        SESystem.instance.PlaySE(0);
    }

    //シーン移動
    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
    public void OnHistoryButton()
    {
        SceneManager.LoadScene("History");
    }
}
