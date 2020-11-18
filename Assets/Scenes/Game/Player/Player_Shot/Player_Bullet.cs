using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour
{

    protected float speed;

    protected float angle;

    protected int t = 0;
    protected int flag = 0;
    protected Vector3 position;

    protected Player_Shot pShot;




    protected void Ini()
    {

        flag = 1;
    }

    

    protected void forward(float v)
    {
        t++;



        position = transform.position;

        position.x -= Mathf.Sin(Mathf.PI * angle / 180) * v;
        position.y += Mathf.Cos(Mathf.PI * angle / 180) * v;

        

        transform.position = position;

    }

    protected void rotate()
    {
        

        transform.rotation = Quaternion.AngleAxis(angle, new Vector3(0, 0, 1));
    }


    protected virtual void Bullet_Destroy(int time)
    {
        //弾丸の終了処理



        if (flag == -1)
        {
            Destroy(gameObject);
        }


        if (t > time)
        {
            flag = -1;
        }


    }


    public int bullet_cnt
    {
        get { return t; }

    }

    public Quaternion bullet_rotation
    {
        get { return transform.rotation; }
        set { transform.rotation = value; }

    }

    public int bullet_falg
    {
        get { return flag; }
        set { flag = value; }

    }

    public Vector3 bullet_posi
    {
        get { return transform.position; }

    }

    public float bullet_angle
    {
        get { return angle; }
        set { angle = value; }
    }



}
