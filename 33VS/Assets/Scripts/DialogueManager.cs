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

    public int _dialogueNodeNumber = 0;
    private bool _waitingForPlayerResponse;

    void Awake()
    {
        _dialogueNodeNumber = 0;
        _currentNode = DialogueList[_dialogueNodeNumber];
        _currentLine = 0;


    }


    public void Update()
    {
        if (!_waitingForPlayerResponse && (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space)))
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
        else if (_currentNode._playerReplyOptions != null && _currentNode._playerReplyOptions.Length > 0)
        {
            // show player dialogue options, if there are any
            _waitingForPlayerResponse = true;
            Cursor.lockState = CursorLockMode.Confined;
            _dialogue.ShowPlayerOptions(_currentNode._playerReplyOptions);
        }
        else
        {

            EndDialogue();
            _currentLine = 0;
            _ctManager.NextPuzzle();


        }


    }

    public void SelectedOption(int option)
    {
        _currentLine = 0;
        _waitingForPlayerResponse = false;
        Cursor.lockState = CursorLockMode.Locked;
        _dialogue.HideOptions();
        _currentNode = _currentNode._npcReplies[option];
        AdvanceDialogue();

    }


    public void EndDialogue()
    {

        _runningDialogue = false;
        _dialogue.HideDialogue();
        _waitingForPlayerResponse = false;
        this.enabled = false;
    }



    public void NextDialogueNode()
    {
        //get new node
        _dialogueNodeNumber++;
        _currentNode = DialogueList[_dialogueNodeNumber];

        //renable dialogue
        this.enabled = true;
        _dialogue.reActivateDialogue();
        ShowStartDialogue();
    }

}
