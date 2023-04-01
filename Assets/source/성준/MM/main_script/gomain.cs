using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gomain : MonoBehaviour
{
    private GameObject target;

    public void OnclickButton()
    {
        Debug.Log("setting");
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Invoke("goto_title", 0.15f);
    }

    void goto_title()
    {
        SceneManager.LoadScene("jjap_title");
    }

}