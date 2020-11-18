using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanae : Chara
{
    
    void Start()
    {
        Ini();
    }

    
    void Update()
    {
        Move(1.02f);
    }
}
