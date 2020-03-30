using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESystem : MonoBehaviour
{

    public static SESystem instance;

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

    void Start()
    {
    }
    public void PlaySE(int index)
    {
        audioSourceSE.PlayOneShot(audioClipsSE[index]);
    }
}
