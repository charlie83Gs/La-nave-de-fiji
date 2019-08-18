using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luminosity.IO;

public class AreaInfo : MonoBehaviour
{
    public int playerNumber;
    public GameObject Male;
    public GameObject Female;
    [SerializeField]
    private GameObject player;
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
        player.GetComponent<PlayerControl>().player = (PlayerID)playerNumber;
    }
}
