using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.blueViolence = !GlobalSettings.Instance.settings.blueViolence;
    }
}
