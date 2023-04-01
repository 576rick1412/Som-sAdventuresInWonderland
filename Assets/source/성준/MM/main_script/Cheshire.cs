using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheshire : MonoBehaviour
{
    public int Cheshire_num = 0;

    private GameObject target;
    void Start()
    {

    }
    void Update()
    {
        target = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
        if (hit.collider != null)
        {
            target = hit.collider.gameObject;
        }
        fire();
    }

    public void fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target == this.gameObject)
            {
                if (Cheshire_num < 1)
                {
                    window call = GameObject.Find("window").GetComponent<window>();
                    call.num += 1;
                    Cheshire_num++;
                    main_move();
                    SceneManager.LoadScene("cat story");
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
        if (call.cheshire == 0)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            call.main_num++;
            call.cheshire++;
        }
    }
}
