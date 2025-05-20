using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InvertoryPanel : MonoBehaviour
{
    public Image selectIcon;
    public TMP_Text descriptionText;
    public Transform rightPanalTransform;
    public GameObject itemButtonPrefab;

    public void OnOpen()
    {
        for (int i = rightPanalTransform.childCount - 1; i >= 0; i--)
        {
            Destroy(rightPanalTransform.GetChild(i).gameObject);
        }
        for (int i = 0;i<InventoryManager.instance.inventoryList.Count; i++)
        {
            GameObject itemButtonObj = Instantiate(itemButtonPrefab,rightPanalTransform) ;
            ItemButton itemButtonComp = itemButtonObj.GetComponent<ItemButton>();
            itemButtonComp.data = InventoryManager.instance.inventoryList[i];
            itemButtonComp.icon.sprite = itemButtonComp.data.itemicon;
            Button button = itemButtonObj.GetComponent <Button>();
            button.onClick.AddListener(() =>
            {
                selectIcon.sprite = itemButtonComp.data.itemicon;
                descriptionText.text = itemButtonComp.data.description;
            });
        }
    }
}
