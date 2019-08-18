using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overpopulation : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.overpopulation = !GlobalSettings.Instance.settings.overpopulation;
    }
}
