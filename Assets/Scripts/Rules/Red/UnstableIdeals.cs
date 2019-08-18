using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnstableIdeals : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.areWeUnstable = !GlobalSettings.Instance.settings.areWeUnstable;
    }
}
