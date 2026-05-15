using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftTableManager : MonoBehaviour
{
    public List<GameObject> _Crafttables;
    public GameObject _currentPuzzle;
    public int _puzzleNumber;

    void Start()
    {
        _puzzleNumber = 0;

        foreach (GameObject table in _Crafttables)
        {
            table.SetActive(false);

        }

    }

    public void EndPuzzle()
    {
        _currentPuzzle.SetActive(false);
    }


    public void NextPuzzle()
    {
        if (_puzzleNumber != 0)
        {
            _puzzleNumber++;
        }
        _currentPuzzle = _Crafttables[_puzzleNumber];
        _currentPuzzle.SetActive(true);
    }
}
