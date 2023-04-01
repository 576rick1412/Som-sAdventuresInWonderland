using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cc_button : MonoBehaviour
{
    private GameObject target;

    public void OnclickButton()
    {
        Debug.Log("play");
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Invoke("goto_play", 0.2f);
    }

    void goto_play()
    {
        SceneManager.LoadScene("omake_7");
    }

}
