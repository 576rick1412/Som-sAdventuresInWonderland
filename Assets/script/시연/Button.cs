using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button: MonoBehaviour
{
    public List<Sprite> sd;
    public Button ddd;
    Image bee;

    public int ns = 0;

    SpriteRenderer on;

    public AudioClip[] Sound;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        on = GetComponent<SpriteRenderer>();

        bee = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        //on.sprite = sd[ns];

        bee.sprite = sd[ns];

    }

    public void RRR()
    {
        ddd.ns++;
        if (ddd.ns >= 6)
        {
            ddd.ns = 0;
        }
        audio.clip = Sound[0];
        audio.Play();
    }

    public void LLL()
    {
        ddd.ns--;
        if (ddd.ns < 0)
        {
            ddd.ns = 5;
        }
        audio.clip = Sound[0];
        audio.Play();
    }


}
