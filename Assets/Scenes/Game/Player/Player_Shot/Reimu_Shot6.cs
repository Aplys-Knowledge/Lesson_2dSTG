using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reimu_Shot6 : Reimu_Shot
{
    protected override void Ini()
    {
        player = GameObject.Find("reimu(Clone)").GetComponent<Chara>();

        base.Ini();
    }

    // Start is called before the first frame update
    void Start()
    {
        Ini();
    }

    // Update is called once per frame
    void Update()
    {
        ShotPow_Mgr();

        Shot(-5, false);
        Bullet_Mgr();


    }
}
