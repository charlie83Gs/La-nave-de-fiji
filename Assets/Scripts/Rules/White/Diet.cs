using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diet : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.glutenFree = !GlobalSettings.Instance.settings.glutenFree;
    }
}
