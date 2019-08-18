using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottenCorpses : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.rottenCorpses = !GlobalSettings.Instance.settings.rottenCorpses;
    }
}
