using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luminosity.IO;

public class AreaInfo : MonoBehaviour
{
    public int playerNumber;
    public GameObject Male;
    public GameObject Female;
    private GameObject player;

    private List<GameObject> creatures = new List<GameObject>();
    public int startingCreatures = 5;
    private void Awake()
    {
        bool isMale = (Random.value > 0.5f);
        if(isMale)
        {
            player = Instantiate(Male, transform.position, Quaternion.identity);
            
        } else
        {
            player = Instantiate(Female, transform.position, Quaternion.identity);
        }
    }

    private void Start()
    {
        player.GetComponent<PlayerControl>().setPlayer(playerNumber);
    }

    public void addCreature(GameObject pCreature)
    {
        creatures.Add(pCreature);
    }
}
