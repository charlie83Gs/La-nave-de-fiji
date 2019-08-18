using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour, IModifier
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.canSpawnColorChanger = !GlobalSettings.Instance.settings.canSpawnColorChanger;
    }
}
