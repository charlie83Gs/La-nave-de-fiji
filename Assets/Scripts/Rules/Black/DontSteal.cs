using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontSteal : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.thief = !GlobalSettings.Instance.settings.thief;
    }
}
