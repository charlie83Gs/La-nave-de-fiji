using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "creature")
        {
            gameObject.GetComponentInParent<CreaturePicker>().canPick = true;
            gameObject.GetComponentInParent<CreaturePicker>().pickableItem = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponentInParent<CreaturePicker>().canPick = false;
        gameObject.GetComponentInParent<CreaturePicker>().pickableItem = null;
    }
}
