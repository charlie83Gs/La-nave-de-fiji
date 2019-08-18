using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaturePicker : MonoBehaviour
{
    private GameObject picker;
    // Start is called before the first frame update
    void Start()
    {
        picker = gameObject.transform.Find("Picker").gameObject;
    }
}
