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
        if (s.instance.i == 0) //���ѷα�
        {
            if (Input.GetMouseButtonUp(0))
            {
                ps.Can_Progress = true;

                s.instance.i = 1;

                Image.SetActive(false);

            }
        }else if(s.instance.i == 1) //�ð��䳢
        {
            if (Input.GetMouseButtonUp(0))
            {
                cr.CrCan_Progress = true;

                s.instance.i = 2;
                
                Image.SetActive(false);

            }
        }else if(s.instance.i == 2) //����
        {

            if (Input.GetMouseButtonUp(0))
            {
                ws.WCan_Progress = true;

                s.instance.i = 3;

                Image.SetActive(false);

            }
        }else if (s.instance.i == 3) //�����
        {

            if (Input.GetMouseButtonUp(0))
            {
                cs.CatCan_Progress = true;

                s.instance.i = 4;

                Image.SetActive(false);

            }
        }
        else if (s.instance.i == 4) //����,�䳢
        {

            if (Input.GetMouseButtonUp(0))
            {
                hs.hCan_Progress = true;

                s.instance.i = 5;

                Image.SetActive(false);

            }
        }
        else if (s.instance.i == 5) //��Ʈ����
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
