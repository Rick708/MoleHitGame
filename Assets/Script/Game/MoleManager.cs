using System;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject TimeCunter;
    TimeCunter timeCunter;


    private void Start()
    {
        timeCunter = GameObject.Find("TimeCunter").GetComponent<TimeCunter>();
    }


    //モグラ情報と点数
    public void OnTap()
    {
        if (timeCunter.StopTime == false)
        {
            SESystem.instance.PlaySE(1);
            Destroy(gameObject);
            GameObject go = GameObject.Find("ScoreCunter");
            ScoreCunter gm = go.GetComponent
                (typeof(ScoreCunter)) as ScoreCunter;
            gm.AddScore(1);
            Instantiate(hitEffect, transform.position, transform.rotation);
        }
    }
}

