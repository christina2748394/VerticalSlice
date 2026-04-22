using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool _canInteract = false;
    public bool _interacting = false;
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
            _interacting = false;
            _interactionPrompt.SetActive(false);
        }


    }
    void Update()
    {
        if (_canInteract && Input.GetKeyDown(KeyCode.E))
        {
            if (_interacting)
            {
                CloseInteracted();
            }
            else
            {
                OnInteracted();
            }

        }


    }
    public virtual void OnInteracted()
    {
        _interacting = true;
        Debug.Log("Interacted");
    }
    public virtual void CloseInteracted()
    {
        _interacting = false;
        Debug.Log("Close Interaction");
    }


}

