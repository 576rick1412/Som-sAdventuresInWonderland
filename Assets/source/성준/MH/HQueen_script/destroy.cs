using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public int boom;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if(boom==1)
        {
            Destroy(gameObject);
        }
    }
}
