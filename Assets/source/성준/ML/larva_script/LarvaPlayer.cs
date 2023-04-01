using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LarvaPlayer : MonoBehaviour
{
    public GameObject clearObject;
    public GameObject apple;
    public GameObject mushroom;
    public GameObject egg;

    public int num = 0;
    public float speed;
    public float B_speed;
    public bool Ttop;
    public bool Tbottom;
    public bool Tleft;
    public bool Tright;
    void Start()
    {
        clearObject.SetActive(false);
        apple.SetActive(false);
        mushroom.SetActive(false);
        egg.SetActive(false);
    }
    void Update()
    {
        move();
        if (num == 3)
        {
            clear();
            Invoke("end", 2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "border")
        {
            switch (collision.gameObject.name)
            {
                case "top":
                    Ttop = true;
                    break;
                case "bottom":
                    Tbottom = true;
                    break;
                case "left":
                    Tleft = true;
                    break;
                case "right":
                    Tright = true;
                    break;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "border")
        {
            switch (collision.gameObject.name)
            {
                case "top":
                    Ttop = false;
                    break;
                case "bottom":
                    Tbottom = false;
                    break;
                case "left":
                    Tleft = false;
                    break;
                case "right":
                    Tright = false;
                    break;
            }
        }
    }
    void move()
    {
        float v = 0;
        float h = Input.GetAxisRaw("Horizontal");
        if ((Tleft && h == -1) || (Tright && h == 1)) 
             h = 0;
        h *= -1;

        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;

        transform.position = curPos + nextPos;
    }

    void clear()
    {
        clearObject.SetActive(true);
    }

    void end()
    {
        s.instance.n = 1;
        SceneManager.LoadScene("worm story");
    }
}
