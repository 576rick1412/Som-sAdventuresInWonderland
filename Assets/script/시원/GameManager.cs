using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } = null;

    public Piece[,] pieces = new Piece[3, 4];

    public float between_val;
    public SpriteRenderer clear;
    public AudioSource clearsound;
    public bool Check()
    { 
        foreach (var p in pieces)
        {
            if(p&&p.index_pos != p.go_pos)
            {
                return false;
            }
            
        }
        return true;
    }
    
    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
    }

    void Update()
    {
    }
}
