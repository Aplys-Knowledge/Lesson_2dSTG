using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{

    private Vector2 Chara_Position;
    private float v = 0;
    private float h = 0;



    protected virtual void Ini()
    {
        Chara_Position = this.transform.position;


    }


    protected virtual void Move()
    {

        Chara_Position = this.transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            v = Input.GetAxis("Vertical") / 12f;
            h = Input.GetAxis("Horizontal") / 12f;


        }
        else
        {
            v = Input.GetAxis("Vertical") / 3f;
            h = Input.GetAxis("Horizontal") / 3f;

        }

        if (v >= 0)
        {
            if(Chara_Position.y < 9f)
            {
                Chara_Position.y += v;
            }

        }
        else
        {
            if (Chara_Position.y > -9f)
            {
                Chara_Position.y += v;
            }

        }

        if (h >= 0)
        {
            if (Chara_Position.x < 8f)
            {
                Chara_Position.x += h;
            }

        }
        else
        {
            if (Chara_Position.x > -15f)
            {
                Chara_Position.x += h;
            }


        }

        transform.position = Chara_Position;
        
    }

}
