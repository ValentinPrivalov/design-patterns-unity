using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    [SerializeField]
    IAbility currentAbility = new DelayedDecorator(new FireballAbility());

    public void UseAbility()
    {
        currentAbility?.Use(gameObject);
    }
}