using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Communism : MonoBehaviour, IRule
{
    public void Apply()
    {
        GlobalSettings.Instance.settings.communism = !GlobalSettings.Instance.settings.communism;
    }
}
