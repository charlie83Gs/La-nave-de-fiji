using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wildlife : MonoBehaviour, IModifier
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.wildlife = !GlobalSettings.Instance.settings.wildlife;
    }
}
