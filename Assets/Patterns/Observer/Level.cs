using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int expPointsPerLevel = 200;
    int currentExpPoints = 0;

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
        currentExpPoints += points;
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
