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
        Mole = Instantiate(MolePrefab);
        MoleManager moleManager = Mole.GetComponent<MoleManager>();
        moleManager.AddEventListenerOnTap(MoleTap);
    }
    //モグラ削除
    void MoleTap()
    {
        // moleManager.AddEventListenerOnTap(MoleTap);
        Debug.Log("いけた！！");
        Destroy(Mole.gameObject);
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
