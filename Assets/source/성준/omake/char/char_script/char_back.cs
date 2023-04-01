using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class char_back : MonoBehaviour
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
        if (move_num == 7)
        {
            SceneManager.LoadScene("omake_main");
        }
        else if (move_num == 8)
        {
            SceneManager.LoadScene("omake_7");
        }
        else if (move_num == 9)
        {
            SceneManager.LoadScene("omake_8");
        }
        else if (move_num == 10)
        {
            SceneManager.LoadScene("omake_9");
        }
        else if (move_num == 11)
        {
            SceneManager.LoadScene("omake_10");
        }
        else if (move_num == 12)
        {
            SceneManager.LoadScene("omake_11");
        }
        else if (move_num == 13)
        {
            SceneManager.LoadScene("omake_12");
        }
    }

}
