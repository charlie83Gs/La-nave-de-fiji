using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racism : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.racism = !GlobalSettings.Instance.settings.racism;
    }
}
