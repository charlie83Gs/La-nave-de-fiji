using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luminosity.IO;

public class CreaturePicker : MonoBehaviour
{
    private SphereCollider picker;
    public bool canPick;
    public GameObject pickableItem;
    private PlayerID player;
    private GameObject pickedItem;
    public float height;
    void Start()
    {
        picker = gameObject.transform.Find("Picker").gameObject.GetComponent<SphereCollider>();
        player = GetComponent<PlayerControl>().player;
    }

    private void Update()
    {
        if(InputManager.GetButtonDown("Grab", player))
        {
            if(!pickedItem && pickableItem)
            {
                pickableItem.transform.position = new Vector3(pickableItem.transform.position.x, pickableItem.transform.position.y + height, pickableItem.transform.position.z);
                pickableItem.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
                pickableItem.GetComponent<PickableCreature>().isPicked = true;
                pickableItem.transform.parent = this.transform;
                pickedItem = pickableItem;
            } else if(pickedItem)
            {
                pickedItem.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                pickedItem.GetComponent<PickableCreature>().isPicked = false;
                pickedItem.transform.parent = this.transform.parent;
                pickedItem = null;
            }
        }
    }
}
