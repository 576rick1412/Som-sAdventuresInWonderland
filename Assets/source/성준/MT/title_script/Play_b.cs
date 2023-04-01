using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play_b : MonoBehaviour
{
    private GameObject target;

    public void OnclickButton()
    {
        Debug.Log("play");
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        goto_play();
    }

    void goto_play()
    {
        SceneManager.LoadScene("main_proto_scene");
    }

}
