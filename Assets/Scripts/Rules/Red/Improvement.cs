using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Improvement : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.canSpawnImprovement = !GlobalSettings.Instance.settings.canSpawnImprovement;
    }
}
