using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueHunger : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.blueHunger = !GlobalSettings.Instance.settings.blueHunger;
    }
}
