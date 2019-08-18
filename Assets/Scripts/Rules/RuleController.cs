using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleController : MonoBehaviour
{
    private IRule[] BlueRules;
    private IRule[] RedRules;
    private IRule[] GreenRules;
    private IRule[] WhiteRules;
    private IRule[] BlackRules;
    private IModifier[] Modifiers;

    public IRule getBlueRule()
    {
        int n = Random.Range(0, BlueRules.Length);
        return BlueRules[n];
    }

    public IRule getRedRule()
    {
        int n = Random.Range(0, RedRules.Length);
        return RedRules[n];
    }

    public IRule getGreenRule()
    {
        int n = Random.Range(0, GreenRules.Length);
        return GreenRules[n];
    }

    public IRule getWhiteRule()
    {
        int n = Random.Range(0, WhiteRules.Length);
        return WhiteRules[n];
    }

    public IRule getBlackRule()
    {
        int n = Random.Range(0, BlackRules.Length);
        return BlackRules[n];
    }

    public IModifier getModifier()
    {
        int n = Random.Range(0, Modifiers.Length);
        return Modifiers[n];
    }
}
