using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CraftingManager : MonoBehaviour
{
    private CraftItems _currentItem;
    public Image _customCursor;
    public Slots[] _craftingSlots;

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
                _currentItem = null;

            }



        }

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
