using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    [SerializeField] private DialogueUI _dialogue;
    [SerializeField] private DialogueNode _dialogueStartNode;

    private DialogueNode _currentNode;
    private int _currentLine = 0;
    private bool _runningDialogue;

    void Start()
    {
        _currentNode = _dialogueStartNode;

    }


    public void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space)))
        {

            AdvanceDialogue();
        }




    }

    public void AdvanceDialogue()
    {
        _runningDialogue = true;

        if (_currentLine < _currentNode._lines.Length)
        {
            // if we still have NPC lines left, keep playing NPC lines
            _dialogue.ShowDialogue(_currentNode._lines[_currentLine]);
            _currentLine++;
        }
        else
        {
            // if there are no NPC or player lines left, close dialogue UI
            EndDialogue();

        }




    }

    private void EndDialogue()
    {
        Debug.Log("Dialog Ended");
        _runningDialogue = false;
        _dialogue.HideDialogue();
    }

}
