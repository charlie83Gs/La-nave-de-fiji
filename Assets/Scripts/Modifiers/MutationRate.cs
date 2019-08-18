using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutationRate : MonoBehaviour, IModifier
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.fasterMutationRate = !GlobalSettings.Instance.settings.fasterMutationRate;
    }
}
