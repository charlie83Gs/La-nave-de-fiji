using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour, IModifier
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.superSpeed = !GlobalSettings.Instance.settings.superSpeed;
    }
}
