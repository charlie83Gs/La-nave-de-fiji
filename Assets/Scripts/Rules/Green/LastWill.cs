using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastWill : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.lastWill = !GlobalSettings.Instance.settings.lastWill;
    }
}
