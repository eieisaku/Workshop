using UnityEngine;

public class ItemBase : MonoBehaviour,IInteractable
{
    public ItemData data;
    public void Interact()
    {
        Debug.Log("interact item :" +  data.name);
        InventoryManager.instance.AddItem(data);
        Destroy(gameObject);
    }
}
