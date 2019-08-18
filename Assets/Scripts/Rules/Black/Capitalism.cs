using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capitalism : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.capitalism = !GlobalSettings.Instance.settings.capitalism;
    }
}
