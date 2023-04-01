using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AA_Prologue : MonoBehaviour
{
    public GameObject who_me;
    public GameObject close_book;
    public GameObject open_book;
    public GameObject see_char;

    private int nanba;

    private GameObject target;

    void Start()
    {
        close_book.SetActive(false);
        M6GA call = GameObject.Find("zizonbox").GetComponent<M6GA>();
        nanba = call.main_num; Debug.Log(call.main_num);

        if (nanba == 1) // 열린책
        {
            see_char.SetActive(false);
        }
        else // 캐릭터
        {
            open_book.SetActive(false);
        }

        //           close_book.SetActive(false);
        //           open_book.SetActive(false);
        //           see_char.SetActive(false);*/
    }
}