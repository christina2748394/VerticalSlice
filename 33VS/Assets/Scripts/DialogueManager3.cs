using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class DialogueManager3 : MonoBehaviour
{
    //This one have Choice Options
    [SerializeField] private DialogueUI _dialogue;
    [SerializeField] public List<DialogueNode> DialogueList;


    private DialogueNode _currentNode;
    private int _currentLine = 0;
    private bool _runningDialogue;

    public int _dialogueNodeNumber;
    private bool _waitingForPlayerResponse;



    void Awake()
    {
        _currentNode = DialogueList[0];
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
            //if the dialogue contains to next scene info
            if (_currentNode._switchToScene != null)
            {
                SceneManager.LoadScene(_currentNode._switchToScene);

            }
            // if there are no NPC or player lines left, close dialogue UI
            else
            {
                EndDialogue();
            }

        }


    }

    public void EndDialogue()
    {

        _runningDialogue = false;
        _dialogue.HideDialogue();
        _waitingForPlayerResponse = false;
        this.enabled = false;
    }
    public void SelectedOption(int option)
    {
        Debug.Log("3 selected");
        _currentLine = 0;
        _waitingForPlayerResponse = false;
        Cursor.lockState = CursorLockMode.Locked;
        _currentNode = _currentNode._npcReplies[option];
        AdvanceDialogue();
    }



    public void NextDialogueNode()
    {
        _dialogueNodeNumber++;
        _currentNode = DialogueList[_dialogueNodeNumber];
    }

}
