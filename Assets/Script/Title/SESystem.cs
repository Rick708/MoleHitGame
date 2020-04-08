using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESystem : MonoBehaviour
{

    public static SESystem instance;

    //SE関係
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public AudioSource audioSourceSE;
    public AudioClip[] audioClipsSE;
    public void PlaySE(int index)
    {
        audioSourceSE.PlayOneShot(audioClipsSE[index]);
    }
}
