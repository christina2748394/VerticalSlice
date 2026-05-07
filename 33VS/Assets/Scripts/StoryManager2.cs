using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryManager2 : MonoBehaviour
{
    //Dialogues
    [SerializeField] public DialogueManager _startDialogue;
    [SerializeField] public DialogueManager _MidDialogue;
    [SerializeField] public DialogueManager _endDialogue;

    //Check target item
    public Slots _resultSlot;
    public Slots _resultSlot2;
    [SerializeField] private CraftItems _targetItem;
    private bool _dayComplete = false;

    //Close Craft Table
    [SerializeField] private GameObject _craftCanvas1;
    [SerializeField] private GameObject _craftCanvas2;


    void Start()
    {
        _startDialogue.ShowStartDialogue();
        _startDialogue.AdvanceDialogue();
        _endDialogue.enabled = false;

    }
    void Update()
    {

        if (_resultSlot._item != null)
        {
            Debug.Log("Target Item Get");
            _craftCanvas1.SetActive(false);
            _MidDialogue.enabled = true;
            _MidDialogue.ShowStartDialogue();
            _resultSlot._item = null;
        }
        if (_resultSlot2._item != null)
        {
            Debug.Log("Target Item Get");
            _craftCanvas2.SetActive(false);
            _endDialogue.enabled = true;
            _endDialogue.ShowStartDialogue();
            _resultSlot._item = null;
            _dayComplete = true;
        }
        if (_dayComplete && _endDialogue.enabled == false)
        {
            Debug.Log("Enter Dream");
            //SceneManager.LoadScene("Dream1");

        }

    }

}
