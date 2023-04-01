using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    public int apple_num = 0;
    public GameObject appleObject;
    public GameObject apple_uiObject;

    private GameObject target;
    void Start()
    {
        apple_uiObject.SetActive(false);
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
        //fire();
         if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target == this.gameObject)
            {
                if (apple_num < 1)
                {
                    apple_num += 1;
                    LarvaPlayer call = GameObject.Find("window").GetComponent<LarvaPlayer>();
                    call.num += 1;
                    appleObject.SetActive(false);
                    apple_uiObject.SetActive(true);
                }
            }

        }
    }

    public void fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target == this.gameObject)
            {
                if (apple_num < 1)
                {
                    apple_num += 1;
                    LarvaPlayer call = GameObject.Find("window").GetComponent<LarvaPlayer>();
                    call.num += 1;
                    appleObject.SetActive(false);
                    apple_uiObject.SetActive(true);
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
}
