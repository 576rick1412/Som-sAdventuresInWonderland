using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class album_b : MonoBehaviour
{

    private GameObject target;

    public void OnclickButton()
    {
        Debug.Log("album");
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        goto_album();
    }

    void goto_album()
    {
        SceneManager.LoadScene("Album");
    }

}
