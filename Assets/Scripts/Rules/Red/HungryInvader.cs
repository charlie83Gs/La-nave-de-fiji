using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryInvader : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.canInvade = !GlobalSettings.Instance.settings.canInvade;
    }
}
