using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolution : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.canSpawnEvolution = !GlobalSettings.Instance.settings.canSpawnEvolution;
    }
}
