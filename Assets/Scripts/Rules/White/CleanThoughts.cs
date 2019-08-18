using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanThoughts : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.trashRepelant = !GlobalSettings.Instance.settings.trashRepelant;
    }
}
