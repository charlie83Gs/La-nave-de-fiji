using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{
    public int PlayerAmount;
    public GameObject PlayerArea;
    private float[] AreaPos = {25f, 25f};
    private int[][] Area = new int[][]
    {
        new int[]{1, 1}, 
        new int[]{1, -1}, 
        new int[]{-1, 1}, 
        new int[]{-1, -1}
    };


    private void Start()
    {
        while(PlayerAmount > 0)
        {
            PlayerAmount--;
            GameObject a = Instantiate(PlayerArea, new Vector3(AreaPos[0] * Area[PlayerAmount][0], 0.01f, AreaPos[1] * Area[PlayerAmount][1]), Quaternion.identity, this.transform);
            a.GetComponent<Renderer>().material.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            a.transform.localScale = new Vector3(AreaPos[0]/5, 1, AreaPos[1]/5);
            a.GetComponent<AreaInfo>().playerNumber = PlayerAmount;
        }
    }
}
