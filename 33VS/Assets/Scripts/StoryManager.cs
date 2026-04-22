using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryManager : MonoBehaviour
{
    //Dialogues
    [SerializeField] public DialogueManager _startDialogue;
    [SerializeField] public DialogueManager _endDialogue;

    //Check target item
    public Slots _resultSlot;
    [SerializeField] private CraftItems _targetItem;
    private bool _dayComplete = false;

    //Close Craft Table
    [SerializeField] private GameObject _craftCanvas;


    void Start()
    {
        _startDialogue.ShowStartDialogue();
        _startDialogue.AdvanceDialogue();
        _endDialogue.enabled = false;

    }
    void Update()
    {

        if (_resultSlot._item == _targetItem)
        {
            Debug.Log("Target Item Get");
            _craftCanvas.SetActive(false);
            _endDialogue.enabled = true;
            _endDialogue.ShowStartDialogue();
            _resultSlot._item = null;
            _dayComplete = true;
        }
        if (_dayComplete && _endDialogue.enabled == false)
        {
            Debug.Log("Enter Dream");
            SceneManager.LoadScene("Dream1");

        }

    }

}
