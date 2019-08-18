using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nationalism : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.nationalism = !GlobalSettings.Instance.settings.nationalism;
    }
}
