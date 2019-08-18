using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour, IModifier
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.toTrees = !GlobalSettings.Instance.settings.toTrees;
    }
}
