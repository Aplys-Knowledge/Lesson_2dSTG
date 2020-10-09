using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marisa : Chara
{

    protected override void Ini()
    {
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
        Move(1.05f);
    }
}
