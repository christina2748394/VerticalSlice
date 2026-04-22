using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCraftTable : Interactable
{
    public GameObject _craftTableUI;
    public override void OnInteracted()
    {
        _craftTableUI.SetActive(true);
    }
}
