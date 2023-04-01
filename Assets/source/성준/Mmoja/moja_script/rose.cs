using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rose : MonoBehaviour
{
    public GameObject player;
    public GameObject clearObject;

    void Start()
    {
        clearObject.SetActive(false);
    }
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            clear();
            Invoke("end",1f);
        }
    }
    
    void clear()
    {
        clearObject.SetActive(true);
    }
    void end()
    {
        s.instance.n = 1;
        SceneManager.LoadScene("hat story");
    }
}
