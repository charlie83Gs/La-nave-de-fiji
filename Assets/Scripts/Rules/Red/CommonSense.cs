using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonSense : MonoBehaviour, IRule
{
    private float multiplier = 0.1f;
    public void Apply()
    {
        GlobalSettings.Instance.settings.suicidalRate += multiplier;
    }
}
