using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAbility : IAbility
{
    public void Use(GameObject gameObject)
    {        
        Debug.Log("Here eat this!");
    }
}
