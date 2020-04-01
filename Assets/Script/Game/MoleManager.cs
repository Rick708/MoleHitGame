using System;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    //Action tapAction;
    public GameObject hitEffect;

    //public void AddEventListenerOnTap(Action action)
    //{
    //    tapAction += action;
    //}

    public void OnTap()
    {
        SESystem.instance.PlaySE(1);
        Destroy(gameObject);
        //tapAction();
    }

    public void OnDestroy()
    {
        GameObject go = GameObject.Find("ScoreCunter");
        ScoreCunter gm = go.GetComponent
            (typeof(ScoreCunter)) as ScoreCunter;
        gm.AddScore(1);
        Instantiate(hitEffect);
    }
}

