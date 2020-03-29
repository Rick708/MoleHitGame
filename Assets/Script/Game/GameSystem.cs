using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public GameObject MolePrefab;
    public GameObject TitleButton;
    public GameObject HistoryButton;
    public GameObject StartButton;
    GameObject Mole;

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

    void EncountMole()
    {
        for(int i = 0; i < 3; i++){
            Mole = Instantiate(MolePrefab);
            MoleManager moleManager = Mole.GetComponent<MoleManager>();
            Vector3 p = moleManager.transform.position;
            p.x = Random.Range(-2, 2);
            p.y = Random.Range(-4, 4);
            moleManager.transform.position = p;
        }
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
