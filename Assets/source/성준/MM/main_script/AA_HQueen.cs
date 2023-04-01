using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AA_HQueen : MonoBehaviour
{
    public GameObject who_me;
    public GameObject close_book;
    public GameObject open_book;
    public GameObject see_char;

    private int nanba;

    private GameObject target;

    void Start()
    {

        M6GA call = GameObject.Find("zizonbox").GetComponent<M6GA>();
        nanba = call.main_num; Debug.Log(call.main_num);

        if (nanba <= 5) //´ÝÈùÃ¥
        {
            close();
        }
        else if (nanba == 6) //¿­¸°Ã¥
        {
            open();
        }
        else if (nanba >= 7) //Ä³¸¯ÅÍ
        {
            achar();
        }

        //           close_book.SetActive(false);
        //           open_book.SetActive(false);
        //           see_char.SetActive(false);
    }

    void close()
    {
        open_book.SetActive(false);
        see_char.SetActive(false);
    }
    void open()
    {
        see_char.SetActive(false);
        close_book.SetActive(false);
    }
    void achar()
    {
        open_book.SetActive(false);
        close_book.SetActive(false);
    }
}