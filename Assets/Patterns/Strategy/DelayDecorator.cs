using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDecorator : IAbility
{
    private IAbility wrappedAbitily;

    public DelayedDecorator(IAbility wrappedAbitily)
    {
        this.wrappedAbitily = wrappedAbitily;
    }

    public void Use(GameObject gameObject)
    {
        // TODO delay
        wrappedAbitily.Use(gameObject);
    }
}
