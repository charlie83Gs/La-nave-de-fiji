using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supremacy : MonoBehaviour, IRule 
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.canSpawnSupremacy = !GlobalSettings.Instance.settings.canSpawnSupremacy;
    }
}
