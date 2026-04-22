using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    [SerializeField] public DialogueManager _startDialogue;
    // Start is called before the first frame update

    void Start()
    {
        _startDialogue.ShowStartDialogue();
        _startDialogue.AdvanceDialogue();

    }

}
