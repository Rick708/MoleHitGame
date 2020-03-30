using System;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    public void OnTap()
    {
        Destroy(gameObject);
    }

    public void OnDestroy()
    {
        GameObject go = GameObject.Find("ScoreCunter");
        ScoreCunter gm = go.GetComponent
            (typeof(ScoreCunter)) as ScoreCunter;
        gm.AddScore(1);
    }
}

