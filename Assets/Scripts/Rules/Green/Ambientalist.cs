using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambientalist : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.isGreenMaster = !GlobalSettings.Instance.settings.isGreenMaster;
    }
}
