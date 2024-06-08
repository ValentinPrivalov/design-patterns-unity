using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int expPointsPerLevel = 200;
    [SerializeField] UnityEvent onLevelUp;
    int currentExpPoints = 0;

    public event Action onLevelUpAction;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExperience(20);
        }
    }

    public void GainExperience(int points)
    {
        int level = GetLevel();
        currentExpPoints += points;
        if (GetLevel() > level)
        {
            onLevelUp.Invoke();

            // check available listeners
            onLevelUpAction?.Invoke();
        }
    }

    public int GetExperience()
    {
        return currentExpPoints;
    }

    public int GetLevel()
    {
        return currentExpPoints / expPointsPerLevel;
    }
}
