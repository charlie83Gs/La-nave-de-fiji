using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shock : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.whiteInactivity = !GlobalSettings.Instance.settings.whiteInactivity;
    }
}
