using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadHabits : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.blueTrashProduction = !GlobalSettings.Instance.settings.blueTrashProduction;
    }
}
