using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{

    private Vector2 Chara_Position;
    private float v = 0;
    private float h = 0;

    private Animator anim;

    protected int scnt = 0;
    protected bool sflag = false;

    protected int pow = 0;


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


    protected void Shot_Mgr()
    {
        if (Input.GetButton("Shot"))
        {
            sflag = true;
            scnt++;



        }
        else
        {
            sflag = false;
            scnt = 0;
        }



    }

    private void Update()
    {
        Shot_Mgr();

        //ショットの動作テスト用
        if (Input.GetKeyDown(KeyCode.P))
        {
            pow += 12;
        }
        Debug.Log(pow);
        
    }

    public bool shot_flag
    {
        get { return sflag; }
    }

    public int shot_cnt
    {
        get { return scnt; }
    }

    public int shot_pow
    {
        get { return pow; }
    }




}
