using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prototype_egg : MonoBehaviour
{
    public GameObject Object;
    public GameObject ui;


    public int ss_num = 0;
    private GameObject target;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target == this.gameObject)
            {
                if (ss_num < 1)
                {
                    Debug.Log("°Å¶õ");
                    ss_num += 1;
                    LarvaPlayer call = GameObject.Find("window").GetComponent<LarvaPlayer>();
                    call.num += 1;
                    Object.SetActive(false);
                    ui.SetActive(true);
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
            //Debug.Log(hit.collider.name);
            target = hit.collider.gameObject;
        }
    }
}
