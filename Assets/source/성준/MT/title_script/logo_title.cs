using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logo_title : MonoBehaviour
{
    public int speed;
    public int h;
    public int v;
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (num < 1)
            {
                Debug.Log("adf");
                Vector3 curPos = transform.position;
                Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;

                transform.position = curPos + nextPos;
                num++;
            }
        }
    }
}
