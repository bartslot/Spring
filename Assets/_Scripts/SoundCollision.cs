using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollision : MonoBehaviour
{
//    bool played;
    AudioClip snd;

    public AudioClip audioClip;    // Add your Audi Clip Here;
                                   // Use this for initialization
    void Start()
    {
    //    played = false;
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = audioClip;
    }

    void OnCollisionEnter()  //Plays Sound Whenever collision detected
    {
        GetComponent<AudioSource>().Play();
    //    if (played == false)
    //    {
    //        GetComponent<AudioSource>().Play();
    //        played = true;
    //    }

    }
}