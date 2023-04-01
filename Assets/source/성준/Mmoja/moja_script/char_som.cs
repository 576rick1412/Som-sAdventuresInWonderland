using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_som : MonoBehaviour
{

    public float speed;
    public float B_speed;
    public bool Ttop;
    public bool Tbottom;
    public bool Tleft;
    public bool Tright;
   

    


    void Update()
    {
        move();
        //Invoke("fire", 1.0f);
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
        float v = Input.GetAxisRaw("Vertical");
        if ((Ttop && v == 1) || (Tbottom && v == -1))
            v = 0;
        float h = Input.GetAxisRaw("Horizontal");
        if ((Tright && h == -1) || (Tleft && h == 1))
            h = 0;
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, v, 0) * (speed * Time.deltaTime);

        transform.position = curPos + nextPos;
    }
}