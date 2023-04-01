using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gohome : MonoBehaviour
{
    private GameObject target;

    public void OnclickButton()
    {
        Debug.Log("setting");
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        musicdes call = GameObject.Find("musicbox").GetComponent<musicdes>();
        call.boom = 1;
        Invoke("goto_title", 0.3f);
    }

    void goto_title()
    {
        SceneManager.LoadScene("jjap_title");
    }

}