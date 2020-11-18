using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_Bullet01 : Player_Bullet
{
    private Player_Bullet pBullet;

    // Start is called before the first frame update
    void Start()
    {
        pBullet = this.gameObject.GetComponent<Player_Bullet>();
        //pBullet.bullet_angle = 0;
        angle = pBullet.bullet_angle;
        Ini();
    }

    // Update is called once per frame
    void Update()
    {
        
        Bullet_Destroy(180);
        pBullet.bullet_falg = flag;
        //pBullet.bullet_angle = 0;
        //angle = pBullet.bullet_angle;

        rotate();
        forward(1f);
        
        
    }
}
