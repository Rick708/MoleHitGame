using System;
using UnityEngine;

public class MoleManager : MonoBehaviour
{
    Action tapAction;

    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }

    public void OnTap()
    {
        tapAction();
    }
}
