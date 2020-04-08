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
    public GameObject scoreCunter;
    //bool MoleStart;
    public GameObject OneMoreStartButton;
    //float MoleNextTime;


    public float span = 3f;
    //初期設定
    void Start()
    {
        OneMoreStartButton.SetActive(false);
        StopButton.SetActive(false);
        ReStartButton.SetActive(false);
        TitleButton.SetActive(false);
        HistoryButton.SetActive(false);
    }

    //ゲーム開始
    public void OnStartButton()
    {
        //MoleStart = true;
        EncountMole();
        StartButton.SetActive(false);
        StopButton.SetActive(true);
        InvokeRepeating("EncountMole", span, span);
    }

    //モグラ出現場所指定
    Vector3[] positions = {
        new Vector3(0, -2, 0),
        new Vector3(4, -2, 0),
        new Vector3(-4, -2, 0),
    };

    //モグラ生成
    void EncountMole()
    {
            for (int i = 0; i < 1; i++)
            {
                Mole = Instantiate(MolePrefab);
                MoleManager moleManager = Mole.GetComponent<MoleManager>();
                int r = Random.Range(0, positions.Length);
                moleManager.transform.position = positions[r];
            }
    }

    //時間切れ
    public void GameStop()
    {
        OneMoreStartButton.SetActive(true);
        CancelInvoke();
        StopButton.SetActive(false);
        TitleButton.SetActive(true);
        HistoryButton.SetActive(true);
        GameObject[] objects;
        objects = GameObject.FindGameObjectsWithTag("Mole");
        for (int i = 0; i < objects.Length; ++i)
        {
            Destroy(objects[i].gameObject);
        }
    }

    //もう一度ゲームで遊ぶ
    public void OneMoreStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
