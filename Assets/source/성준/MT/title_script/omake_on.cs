using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omake_on : MonoBehaviour
{
    public GameObject omakelock;
    public GameObject omake;
    private int num = 0;
    void Start()
    {
        lock_img();
    }
 
    void lock_img()
    {
        M6GA call = GameObject.Find("zizonbox").GetComponent<M6GA>();
        num = call.lock_num;
        if (num == 0)
        {
            omake.SetActive(false);
        }
        else if (num == 1)
        {
            omakelock.SetActive(false);
        }
    }
}
