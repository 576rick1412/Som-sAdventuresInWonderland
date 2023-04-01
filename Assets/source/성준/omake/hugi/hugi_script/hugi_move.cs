using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hugi_move : MonoBehaviour
{
    private GameObject target;
    public int move_num = 7;

    public void OnclickButton()
    {
        Debug.Log("play");
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Invoke("goto_play", 0.15f);
    }

    void goto_play()
    {
        if (move_num == 1)
        {
            SceneManager.LoadScene("omake_2");
        }
        else if (move_num == 2)
        {
            SceneManager.LoadScene("omake_3");
        }
        else if (move_num == 3)
        {
            SceneManager.LoadScene("omake_4");
        }
        else if (move_num == 4)
        {
            SceneManager.LoadScene("omake_5");
        }
        else if (move_num == 5)
        {
            SceneManager.LoadScene("omake_6");
        }
        else if (move_num == 6)
        {
            SceneManager.LoadScene("omake_main");
        }
    }

}
