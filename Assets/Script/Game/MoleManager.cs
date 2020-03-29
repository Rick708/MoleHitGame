using System;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    //Action tapAction;

    //public void AddEventListenerOnTap(Action action)
    //{
    //    tapAction += action;
    //}

    //モグラ削除
    public void OnTap()
    {
        Destroy(gameObject);
        //tapAction();
    }
}
