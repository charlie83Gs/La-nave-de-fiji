using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildAttack : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.frenzy = !GlobalSettings.Instance.settings.frenzy;
    }
}
