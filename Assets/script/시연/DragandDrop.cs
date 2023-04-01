using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragandDrop : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public List<GameObject> cb;

    Vector3 st;

    public Button smb;

    public int a = 0;

    public GameObject clear;

    public AudioClip[] Sound;
    AudioSource audio;


    void Start()
    {

        audio = GetComponent<AudioSource>();

    }
    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 v3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(v3.x, v3.y);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.position = st;
        Vector3 vector3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        //031452
        if (vector3.x < 860 && vector3.y < 460 && vector3.x > 0 && vector3.y > -445)
        {



            if (smb.ns == 0 && a == 0)
            {
               
                cb[0].SetActive(true);

               
                audio.clip = Sound[0];
                audio.Play();

                a = 3;

            }


            if (smb.ns == 3 && a == 3)
            {
                cb[3].SetActive(true);
                a = 1;
                audio.clip = Sound[0];
                audio.Play();

            }

          

            if (smb.ns == 1 && a == 1)
            {
                cb[1].SetActive(true);
                a = 4;
                audio.clip = Sound[0];
                audio.Play();
            }

          
            if (smb.ns == 4 && a == 4)
            {
                cb[4].SetActive(true);
                a = 5;
                audio.clip = Sound[0];
                audio.Play();
            }

            if (smb.ns == 5 && a == 5)
            {
                cb[5].SetActive(true);
                a = 2;
                audio.clip = Sound[0];
                audio.Play();
            }

          
            if (smb.ns == 2 && a == 2)
            {
                cb[2].SetActive(true);

                clear.SetActive(true);

                s.instance.n += 1;

                audio.clip = Sound[1];

                audio.Play();

                Invoke("rabbit", 1.5f);

            }

          

        }

    }

    private void Awake()
    {
        st = transform.position;

    }


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);
    }

    void rabbit()
    {
        SceneManager.LoadScene("clock rabbit_story");
    }
}

    
