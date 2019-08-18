using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingPill : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.SleepingPill = !GlobalSettings.Instance.settings.SleepingPill;
    }
}
