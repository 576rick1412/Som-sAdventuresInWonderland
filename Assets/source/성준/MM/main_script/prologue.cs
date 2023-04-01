using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prologue : MonoBehaviour
{
    public int Rabbit_num = 0;

    private GameObject target;
    void Start()
    {

    }
    void Update()
    {
        fire();
    }

    public void fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target == this.gameObject)
            {
                window call = GameObject.Find("window").GetComponent<window>();
                if (call.num == 0)
                {
                    if (Rabbit_num < 1)
                    {
                        call.num += 1;
                        main_move();
                        Rabbit_num++;
                        SceneManager.LoadScene("prologue_story");
                        
                    }
                }
            }

        }
    }
    void CastRay()
    {
        target = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
        if (hit.collider != null)
        {
            target = hit.collider.gameObject;
        }
    }
    void main_move()
    {
        M6GA call = GameObject.Find("zizonbox").GetComponent<M6GA>();
        if(call.prologue==0)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            call.main_num++;
            call.prologue++;
        }
    }
}
