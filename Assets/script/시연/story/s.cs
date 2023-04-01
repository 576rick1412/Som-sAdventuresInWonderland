using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class s : MonoBehaviour
{

    public static s instance = null;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(instance != this)
            {
                Destroy(this.gameObject);
            }

        }
    }

    public int i = 0;
    public int n = 0;

    
}
