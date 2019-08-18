using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyNeighbor : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.dirtyNeighbor = !GlobalSettings.Instance.settings.dirtyNeighbor;
    }
}
