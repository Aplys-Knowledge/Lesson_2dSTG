using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{

    private Vector2 Chara_Position;
    private float v = 0;
    private float h = 0;

    private Animator anim;


    protected virtual void Ini()
    {
        Chara_Position = this.transform.position;
        anim = GetComponent<Animator>();

    }


    protected void Move(float speed)
    {

        Chara_Position = this.transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            v = Input.GetAxis("Vertical") / 12f;
            h = Input.GetAxis("Horizontal") / 12f;


        }
        else
        {
            v = Input.GetAxis("Vertical") * speed / 3f;
            h = Input.GetAxis("Horizontal") * speed / 3f;

        }


        if (Mathf.Abs(h) < 0.02f)
        {
            h = 0;
        }



        anim.SetFloat("HV", h);
        


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
