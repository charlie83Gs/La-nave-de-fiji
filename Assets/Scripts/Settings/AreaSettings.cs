using UnityEngine;

public class AreaSettings
{
    //General Settings
    [Header("General Settings")]
    public float speedMultiplier = 1f;

    //Black Rules
    [Header("Black Settings")]
    public float trashProduction = 1f; //MoreTrash
    public float greenHungerMultiplier = 1f; //MoreHunger
    public float peaceMultiplier = 1f; //RedPeace
    public bool blueHunger = false; //BlueHunger
    public bool thief = false; //DontSteal
    public bool dirtyNeighbor = false; //DirtyNeighbor
    public bool blackParasite = false; //UsefulParasite
    public bool overpopulation = false; //OverPopulation
    public float toxicityMultiplier = 1f; //ToxicWaste
    public bool capitalism = false; //Capitalism
    public bool rottenCorpses = false; //RottenCorpses
    public bool racism = false; //Racism
    public bool nationalism = false; //Nationalism

    //Green Rules
    [Header("Green Settings")]
    public bool isGreenMaster = false; //Ambientalist
    public float greenEatingSpeed = 1f; //Recicling
    public float greenReproductionRate = 1f; //NaturalSelection
    public bool dirtyWork = false; //DirtyWork
    public bool lastWill = false; //LastWill

    //Red Rules
    [Header("Red Settings")]
    public float suicidalRate = 1f; //CommonSense
    public bool frenzy = false; //WildAttack
    public bool canSpawnImprovement = false; //Improvement
    public bool canSpawnEvolution = false; //Evolution
    public bool canSpawnSupremacy = false; //Supremacy
    public bool fearless = false; //Fear
    public bool canSpy = false; //Spy
    public bool canInvade = false; //HungryInvader
    public bool areWeUnstable = false; //UnstableIdeals

    //White Rules
    [Header("White Settings")]
    public bool glutenFree = false; //Diet
    public bool badRelationship = false; //ToxicRelationship
    public float calmAreaMultiplier = 1f; //ZenMaster
    public bool trashRepelant = false; //CleanThoughts
    public bool whiteInactivity = false; //Shock
    public bool canCreateGreen = false; //LifeCycle
    public bool SleepingPill = false; //SleepingPill
    public float whiteReproductionRate = 1f; //WhiteMatingSeason

    //Blue Rules
    [Header("Blue Settings")]
    public float blueFoodProductionRate = 1f; //EffectiveWorker, LazyWorker
    public bool blueViolence = false; //Strike
    public bool blueTrashProduction = false; // BadHabits
    public float blueMovementSpeed = 1f; // SlowMotion
    public float blueReproductionRate = 1f; // BlueMatingSeason
    public bool communism = false; // Communism
}
