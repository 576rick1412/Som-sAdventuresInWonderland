using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class omake_b : MonoBehaviour
{

    private GameObject target;

    public void OnclickButton()
    {
        Debug.Log("omake");
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        goto_omake();
    }
       
    void goto_omake()
    {
        SceneManager.LoadScene("omake_main");
    }

}