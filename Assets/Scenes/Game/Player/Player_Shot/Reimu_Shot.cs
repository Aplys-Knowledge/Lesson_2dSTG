using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reimu_Shot : Player_Shot
{
    protected override void Ini()
    {
        base.Ini();
        P_Shot[0] = GameObject.Find("PShot1");
        P_Shot[1] = GameObject.Find("PShot2");
        P_Shot[2] = GameObject.Find("PShot3");
        P_Shot[3] = GameObject.Find("PShot4");
        P_Shot[4] = GameObject.Find("PShot5");
        P_Shot[5] = GameObject.Find("PShot6");
        P_Shot[6] = GameObject.Find("PShot7");
        P_Shot[7] = GameObject.Find("PShot8");
        P_Shot[8] = GameObject.Find("PShot9");

    }



    protected override void ShotPow_Mgr()
    {
        

        if (player.shot_pow < 8)
        {

            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);


        }
        if (player.shot_pow >= 8 && player.shot_pow < 16)
        {
            P_Shot[0].SetActive(false);
            P_Shot[1].SetActive(true);
            P_Shot[2].SetActive(true);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

        }
        if (player.shot_pow >= 16 && player.shot_pow < 32)
        {
            P_Shot[0].SetActive(false);
            P_Shot[1].SetActive(true);
            P_Shot[2].SetActive(true);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);

        }
        if (player.shot_pow >= 32 && player.shot_pow < 64)
        {
            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(true);
            P_Shot[4].SetActive(true);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);


        }
        if (player.shot_pow >= 64 && player.shot_pow < 80)
        {
            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(true);
            P_Shot[4].SetActive(true);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);


        }
        if (player.shot_pow >= 80 && player.shot_pow < 128)
        {
            P_Shot[0].SetActive(true);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(true);
            P_Shot[4].SetActive(true);

            P_Shot[5].SetActive(false);
            P_Shot[6].SetActive(false);
            P_Shot[7].SetActive(false);
            P_Shot[8].SetActive(false);


        }
        if (player.shot_pow >= 128)
        {
            P_Shot[0].SetActive(false);
            P_Shot[1].SetActive(false);
            P_Shot[2].SetActive(false);
            P_Shot[3].SetActive(false);
            P_Shot[4].SetActive(false);

            P_Shot[5].SetActive(true);
            P_Shot[6].SetActive(true);
            P_Shot[7].SetActive(true);
            P_Shot[8].SetActive(true);

        }


    }
    


}
