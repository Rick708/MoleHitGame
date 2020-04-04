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
    public GameObject ReStartButton;
    public GameObject StopButton;

    bool MoleStart;

    //初期設定
    void Start()
    {
        StopButton.SetActive(false);
        ReStartButton.SetActive(false);
        TitleButton.SetActive(false);
        HistoryButton.SetActive(false);
    }

    //ゲーム開始
    public void OnStartButton()
    {
        Destroy(this.gameObject);
        MoleStart = true;
        EncountMole();
        StartButton.SetActive(false);
        StopButton.SetActive(true);
    }

    //モグラ出現
    //これだと永遠出るからコルーチン使って１秒に１回に変える。その後止める
    //private void Update()
    //{
    //    if (MoleStart == true)
    //    {
    //        EncountMole();
    //    }
    //}
    Vector3[] positions = {
        new Vector3(1, 0, 0),
        //new Vector3(3, -2, 0),
        //new Vector3(-3, -2, 0),
        new Vector3(5, 0, 0),
        new Vector3(-5, 0, 0),
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

    //時間切れでボタン表示する
    public void GameStop()
    {
        Debug.Log("owari");
        StopButton.SetActive(false);
        TitleButton.SetActive(true);
        HistoryButton.SetActive(true);
        //点数保存


        //もぐら削除 タグ機能使ってみた。
        GameObject[] objects;
        objects = GameObject.FindGameObjectsWithTag("Mole");
        for (int i = 0; i < objects.Length; ++i)
        {
            Destroy(objects[i].gameObject);
        }
    }

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
