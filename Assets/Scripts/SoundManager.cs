using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] destroyNoise;
    public static SoundManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void PlayRandomDestroyNoise()
    {
        //Choose a random number
        int clipToPlay = Random.Range(0, destroyNoise.Length);
        //Play that clip
        destroyNoise[clipToPlay].Play();
    }
}
