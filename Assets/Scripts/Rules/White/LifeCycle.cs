using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.canCreateGreen = !GlobalSettings.Instance.settings.canCreateGreen;
    }
}
