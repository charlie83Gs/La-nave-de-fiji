using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giants : MonoBehaviour, IModifier
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.giants = !GlobalSettings.Instance.settings.giants;
    }
}
