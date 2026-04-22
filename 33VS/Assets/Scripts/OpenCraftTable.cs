using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCraftTable : Interactable
{
    public GameObject _craftTableUI;
    public override void OnInteracted()
    {
        _interacting = true;
        _craftTableUI.SetActive(true);
    }

    public override void CloseInteracted()
    {
        _interacting = false;
        _craftTableUI.SetActive(false);
    }

}
