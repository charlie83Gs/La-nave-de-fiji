using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spy : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.canSpy = !GlobalSettings.Instance.settings.canSpy;
    }
}
