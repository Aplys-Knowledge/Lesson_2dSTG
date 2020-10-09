using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanae : Chara
{

    protected override void Ini()
    {
        base.Ini();


    }

    void Start()
    {
        Ini();
    }

    
    void Update()
    {
        Move(1.02f);
    }
}
