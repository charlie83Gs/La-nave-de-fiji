using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fear : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.fearless = !GlobalSettings.Instance.settings.fearless;
    }
}
