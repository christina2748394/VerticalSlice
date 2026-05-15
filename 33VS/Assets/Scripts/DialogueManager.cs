using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    [SerializeField] private DialogueUI _dialogue;
    [SerializeField] public CraftTableManager _ctManager;

    [SerializeField] public List<DialogueNode> DialogueList;


    private DialogueNode _currentNode;
    private int _currentLine = 0;
    private bool _runningDialogue;

    public int _dialogueNodeNumber;

    void Awake()
    {
        _currentNode = DialogueList[0];
        _currentLine = 0;

    }


    public void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space)))
        {
            AdvanceDialogue();
        }




    }

    public void ShowStartDialogue()
    {
        _runningDialogue = true;
        _dialogue.ShowDialogue(_currentNode._lines[_currentLine]);
        _dialogue.ShowDialogue(_currentNode._lines[_currentLine]);
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
            //Invoke?
            EndDialogue();
            _currentLine = 0;
            _ctManager.NextPuzzle();
        }




    }

    public void EndDialogue()
    {

        _runningDialogue = false;
        _dialogue.HideDialogue();
        this.enabled = false;
    }



    public void NextDialogueNode()
    {
        _dialogueNodeNumber++;
        _currentNode = DialogueList[_dialogueNodeNumber];
    }

}
