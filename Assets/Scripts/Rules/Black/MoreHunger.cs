using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreHunger : MonoBehaviour, IRule
{
    private float multiplier = 0.1f;
    public void Apply()
    {
        GlobalSettings.Instance.settings.greenHungerMultiplier += multiplier;
    }
}
