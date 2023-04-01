using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicdes : MonoBehaviour
{
    public int boom;
    void Start()
    {
        var obj = FindObjectsOfType<musicdes>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (boom == 1)
        {
            Destroy(gameObject);
        }
    }
}
