using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CraftingManager : MonoBehaviour
{
    private CraftItems _currentItem;
    public Image _customCursor;
    public Slots[] _craftingSlots;
    public List<CraftItems> _itemList;
    public string[] _recipes;
    public CraftItems[] _recipeResults;
    public Slots resultSlot;

    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (_currentItem != null)
            {
                _customCursor.gameObject.SetActive(false);
                Slots nearestSlot = null;
                float shortestDistance = float.MaxValue;
                foreach (Slots slot in _craftingSlots)
                {
                    float dis = Vector2.Distance(Input.mousePosition, slot.transform.position);
                    if (dis < shortestDistance)
                    {
                        shortestDistance = dis;
                        nearestSlot = slot;
                    }
                }
                nearestSlot.gameObject.SetActive(true);
                nearestSlot.GetComponent<Image>().sprite = _currentItem.GetComponent<Image>().sprite;
                nearestSlot._item = _currentItem;
                _itemList[nearestSlot._index] = _currentItem;
                _currentItem = null;
                CheckforCompletedReipies();

            }



        }

    }

    public void CheckforCompletedReipies()
    {
        resultSlot.gameObject.SetActive(false);
        resultSlot._item = null;

        string currentRecipeString = "";
        foreach (CraftItems item in _itemList)
        {
            if (item != null)
            {
                currentRecipeString += item._itemName;
            }
            else
            {
                currentRecipeString += "null";
            }
        }
        for (int i = 0; i < _recipes.Length; i++)
        {
            if (_recipes[i].Equals(currentRecipeString))
            {
                resultSlot.gameObject.SetActive(true);
                resultSlot.GetComponent<Image>().sprite = _recipeResults[i].GetComponent<Image>().sprite;
                resultSlot._item = _recipeResults[i];

            }
        }

    }
    public void OnClickSlots(Slots slot)
    {
        slot._item = null;
        _itemList[slot._index] = null;
        slot.gameObject.SetActive(false);
        CheckforCompletedReipies();

    }


    public void OnMouseDownItem(CraftItems item)
    {
        if (_currentItem == null)
        {
            _currentItem = item;
            _customCursor.gameObject.SetActive(true);
            _customCursor.sprite = _currentItem.GetComponent<Image>().sprite;
        }
    }

}
