using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Reimu : Chara
{




    // Start is called before the first frame update
    void Start()
    {
        Ini();
    }

    // Update is called once per frame
    void Update()
    {
        Move(1f);


    }
}
