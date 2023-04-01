using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Qqqq : MonoBehaviour
{
    public Hqstory Hq;
    public story ps;
    public s2 cr;
    public wstory ws;
    public cstory cs;
    public hstory hs;
    public GameObject Image;
    public GameObject WBackGround;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ok()
    {
        if (s.instance.i == 0) //프롤로그
        {
            if (Input.GetMouseButtonUp(0))
            {
                ps.Can_Progress = true;

                s.instance.i = 1;

                Image.SetActive(false);

            }
        }else if(s.instance.i == 1) //시계토끼
        {
            if (Input.GetMouseButtonUp(0))
            {
                cr.CrCan_Progress = true;

                s.instance.i = 2;
                
                Image.SetActive(false);

            }
        }else if(s.instance.i == 2) //벌레
        {

            if (Input.GetMouseButtonUp(0))
            {
                ws.WCan_Progress = true;

                s.instance.i = 3;

                Image.SetActive(false);

            }
        }else if (s.instance.i == 3) //고양이
        {

            if (Input.GetMouseButtonUp(0))
            {
                cs.CatCan_Progress = true;

                s.instance.i = 4;

                Image.SetActive(false);

            }
        }
        else if (s.instance.i == 4) //모자,토끼
        {

            if (Input.GetMouseButtonUp(0))
            {
                hs.hCan_Progress = true;

                s.instance.i = 5;

                Image.SetActive(false);

            }
        }
        else if (s.instance.i == 5) //하트여왕
        {

            if (Input.GetMouseButtonUp(0))
            {
                Hq.Can_Progress = true;

                s.instance.i = 6;

                Image.SetActive(false);
                WBackGround.SetActive(false);

            }
        }else if (s.instance.i == 6) //End
        {

            if (Input.GetMouseButtonUp(0))
            {
                Hq.EndCan_Progress = true;

                s.instance.i = 7;

                Image.SetActive(false);

            }
        }
        /*
        if (Input.GetMouseButtonUp(0))
        {
            Hq.Can_Progress = true;
            Debug.Log("hhhhhhhhhhh");
            s.instance.i = 1;
            Image.SetActive(false);
            WBackGround.SetActive(false);

        }
        */
    }

}
