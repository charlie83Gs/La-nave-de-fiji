using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicRelationship : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.badRelationship = !GlobalSettings.Instance.settings.badRelationship;
    }
}
