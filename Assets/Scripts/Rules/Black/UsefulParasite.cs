using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefulParasite : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.blackParasite = !GlobalSettings.Instance.settings.blackParasite;
    }
}
