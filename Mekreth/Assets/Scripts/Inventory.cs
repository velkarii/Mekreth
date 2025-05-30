using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool InventoryIsOpen = false;
    public GameObject InventoryUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InventoryIsOpen = !InventoryIsOpen;
            InventoryUI.SetActive(InventoryIsOpen);

            if (InventoryIsOpen)
            {
                InventoryManager.Instance.ListItems();
            }
        }
    }
}
