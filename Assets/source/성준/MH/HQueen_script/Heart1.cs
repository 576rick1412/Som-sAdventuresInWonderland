using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart1 : MonoBehaviour
{
    public GameObject Object;
    public GameObject ui;

    private int hh_num = 0;
    private GameObject target;
    
    void Start()
    {
        ui.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target == this.gameObject)
            {   
                Debug.Log("Å¬¸¯µÊ");    
                Object.SetActive(false);    
                ui.SetActive(true);
                Invoke("goto_move", 0.4f);
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
            //Debug.Log (hit.collider.name);
            target = hit.collider.gameObject;
        }
    }
    void goto_move()
    {
        SceneManager.LoadScene("HQueen_2");
    }
}
