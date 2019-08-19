using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AreaInfo : MonoBehaviour
{
  public int playerNumber;
  public GameObject Male;
  public GameObject Female;
    public bool hasSwpawned = false;
  private GameObject player;
  public List<GameObject> creatures = new List<GameObject>();
  private void Awake()
  {
    bool isMale = (Random.value > 0.5f);
    if (isMale)
    {
      player = Instantiate(Male, transform.position, Quaternion.identity);

    }
    else
    {
      player = Instantiate(Female, transform.position, Quaternion.identity);
    }
  }

  private void Start()
  {
    player.GetComponent<PlayerControl>().setPlayer(playerNumber);
  }

  private void LateUpdate()
  {
    if (!creatures.Any() && hasSwpawned)
    {
            Debug.Log(creatures.Any());
      Destroy(gameObject);
    }
  }

  public void addCreature(GameObject pCreature)
  {
    creatures.Add(pCreature);
  }

  public void removeCreature(GameObject pCreature)
  {
    creatures.Remove(pCreature);
  }

  public bool hasCreature(GameObject pCreature)
  {
    return creatures.Contains(pCreature);
  }



}
