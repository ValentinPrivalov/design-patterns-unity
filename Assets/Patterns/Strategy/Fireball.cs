using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAbility : IAbility
{
    public void Use(GameObject gameObject)
    {
        Debug.Log("Launch fireball");
    }
}
