using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbits : MonoBehaviour, IModifier
{
    private float multiplier = 0.1f;
    public void Apply()
    {
        GlobalSettings.Instance.settings.globalReproductionRate += multiplier;
    }
}
