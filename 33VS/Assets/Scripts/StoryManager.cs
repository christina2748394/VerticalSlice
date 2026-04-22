using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    [SerializeField] public DialogueManager _startDialogue;
    // Start is called before the first frame update
    public Slots _resultSlot;
    [SerializeField] private CraftItems _targetItem;

    void Start()
    {
        _startDialogue.ShowStartDialogue();
        _startDialogue.AdvanceDialogue();

    }
    void Update()
    {
        if (_resultSlot._item = _targetItem)
        {
            Debug.Log("Target Item Get");
        }

    }

}
