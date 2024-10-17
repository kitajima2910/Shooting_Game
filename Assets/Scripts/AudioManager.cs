using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioSource backGroundsource;
    public AudioSource sfxsource;

    public AudioClip shootClip;
    public AudioClip deadClip;
    public AudioClip backgroundClip;

    public void Awake()
    {
        instance = this;

        PlayBackground();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayBackground()
    {
        backGroundsource.clip = backgroundClip;
        backGroundsource.Play();
    }

    public void PlayShootClip()
    {
        sfxsource.PlayOneShot(shootClip);
    }

    public void PlayDeadClip()
    {
        sfxsource.PlayOneShot(deadClip);
    }
}
