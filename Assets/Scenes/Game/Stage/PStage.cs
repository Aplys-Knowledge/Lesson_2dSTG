using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStage : MonoBehaviour
{
    protected int stage_num;

    protected int stage_cnt = 0;

    protected int stage_state;


    private new string[] name = new string[3] { "reimu", "marisa", "sanae" };

    protected GameObject player;
    private Chara PChara;


    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        stage_cnt++;
    }



    protected virtual void Ini(int n)
    {
        stage_num = n;
        stage_state = 0;



    }

    protected virtual void Player_Appear()
    {
        player = Instantiate((GameObject)Resources.Load("Player/" + name[1]), new Vector2(0,0), Quaternion.identity);



        PChara = player.GetComponent<Chara>();



    }

    protected void Stage_Mgr()
    {
        
    }







}
