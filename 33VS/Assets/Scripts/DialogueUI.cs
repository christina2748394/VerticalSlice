using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _npcText;
    [SerializeField] private GameObject _npcDialogue;


    void Awake()
    {
        //HideDialogue();
    }


    public void ShowDialogue(string dialogue)
    {
        gameObject.SetActive(true);
        _npcDialogue.SetActive(true);
        _npcText.text = dialogue;
    }



    public void HideDialogue()
    {

        _npcDialogue.SetActive(false);
        gameObject.SetActive(false);
    }
}