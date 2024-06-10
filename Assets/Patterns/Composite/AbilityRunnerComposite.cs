using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRunnerComposite : MonoBehaviour
{
    [SerializeField]
    IAbility currentAbility = new SequenceComposite(
        new IAbility[] {
            new HealAbility(),
            new RageAbility(),
            new DelayedDecorator(new FireballAbility())
        }
    );

    public void UseAbility()
    {
        currentAbility?.Use(gameObject);
    }
}

public class SequenceComposite : IAbility
{
    private IAbility[] children;

    public SequenceComposite(IAbility[] children)
    {
        this.children = children;
    }

    public void Use(GameObject gameObject)
    {
        foreach (IAbility child in children)
        {
            child.Use(gameObject);
        }
    }
}