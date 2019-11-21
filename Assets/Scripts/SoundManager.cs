using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip Sound_Click;
    public AudioClip Sound_Die;
    public AudioClip Sound_Potion;
    public AudioClip Sound_SavePoint;
    public AudioClip MainMenu_Sound;
    public AudioClip Play_Sound;

    public AudioSource myAudio;

    public static SoundManager instance;
    

    void Awake()
    {
        if (SoundManager.instance == null)
        {
            SoundManager.instance = this;
        }
    }

    void Start()
    {
        myAudio = gameObject.GetComponent<AudioSource>();
        myAudio.clip = MainMenu_Sound;
        myAudio.Play();
    }

    void Update()
    {
        
    }


    public void SoundClick()
    {
        myAudio.PlayOneShot(Sound_Click);
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(Sound_Die);
    }

    public void SoundPotion()
    {
        myAudio.PlayOneShot(Sound_Potion);
    }

    public void SoundSavePoint()
    {
        myAudio.PlayOneShot(Sound_SavePoint);
    }

    public void SoundOff()
    {
        myAudio.volume = 0;
    }

    public void SoundOn()
    {
        myAudio.volume = 1;
    }
}
