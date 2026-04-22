using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool _canInteract = false;
    public GameObject _interactionPrompt;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            _canInteract = true;
            _interactionPrompt.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _canInteract = false;
            _interactionPrompt.SetActive(false);
        }


    }
    void Update()
    {
        if (_canInteract && Input.GetKeyDown(KeyCode.E))
        {
            OnInteracted();

        }
    }
    public virtual void OnInteracted()
    {
        Debug.Log("Interacted");
    }

}

