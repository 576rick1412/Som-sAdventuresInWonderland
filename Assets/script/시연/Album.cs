using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Album : MonoBehaviour
{
    public List<GameObject> off;
    public List<Sprite> on;

    public List<Image> B_on;

    public List<Image> offimg;

    public AudioClip[] Sound;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        int a = 0;

        foreach (Image image in offimg)
        {
            if (s.instance.i >= a + 1)
            {
                image.sprite = on[a];
            }

            a++;
        }
    }

    //B_on[0].gameObject.SetActive(true);


    public void Bt(int btbt)
    {

        int a = 0;

        foreach (GameObject game in off)
        {

            if (btbt == a)
            {

                if (s.instance.i >= a + 1)
                {
                    audio.clip = Sound[0];
                    audio.Play();

                    B_on[a].gameObject.SetActive(true);

                    StartCoroutine(close(a));
                }
            }
            a++;
        }
    }

    IEnumerator close(int Bimg)
    {
        while (!Input.GetMouseButtonDown(0))
        {
            yield return null;
        }

        audio.clip = Sound[0];
        audio.Play();

        B_on[Bimg].gameObject.SetActive(false);

    }

    public void back()
    {
        if (Input.GetMouseButtonUp(0))
        {
            audio.clip = Sound[0];
            audio.Play();

            SceneManager.LoadScene("jjap_title");
        }
    }

}



/*if (s.instance.i == 1)
       {
           offimg[0].sprite = on[0];
       }
       */