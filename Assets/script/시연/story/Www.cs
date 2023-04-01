using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Www : MonoBehaviour
{
    public AudioClip[] BackGroundSound;
    AudioSource audio;

    public hstory hbgm;
    public Hqstory hqbgm;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bgm()
    {
        if(hbgm.hat_bgm == false)
        {
            audio.clip = BackGroundSound[0];
            audio.Play();
        }else if(hbgm.hat_bgm == true)
        {
            audio.clip = BackGroundSound[1];
            audio.Play();
        }
    }

    public void Hqbgm()
    {
        if (hqbgm.hq_bgm == true)
        {
            audio.clip = BackGroundSound[2];
            audio.Play();
        }
        else if (hqbgm.hq_bgm == false)
        {
            audio.clip = BackGroundSound[3];
            audio.Play();
        }
    }
}
