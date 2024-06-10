using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RageAbility : IAbility
{
    public void Use(GameObject gameObject)
    {        
        Debug.Log("I'm always angry");
    }
}
