using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rose_copy : MonoBehaviour
{
    public GameObject clear;
    void Start()
    {
        clear.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("scenemove", 1f);
    }
    void scenemove()
    {
        Debug.Log("Ãæµ¹");
        clear.SetActive(true);
        SceneManager.LoadScene("main_proto_scene");
    }
}
