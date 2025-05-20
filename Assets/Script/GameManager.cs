using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public InvertoryPanel invertoryPanel;

    public void OpeninventoryPanel()
    {
        invertoryPanel.gameObject.SetActive(true);
        invertoryPanel.OnOpen();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }
    public void CloseinventoryPanel()
    {
        invertoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
    public float timeCounter = 30f;
    public ItemData targetItem;
    public int targetAmout = 5;

    public TMP_Text timeCounterText;
    public Image targetItemIcon;
    public TMP_Text targetCurrentAmountText;

    public bool isPlayerWin = false;

    private void Start()
    {
        targetItemIcon.sprite = targetItem.itemIcon;
    }
    private void Update()
    {
        if(isPlayerWin)
            return;
        
        if(timeCounter > 0)
        {
            timeCounter -= Time.deltaTime;
            timeCounterText.text = timeCounter.ToString();
            targetCurrentAmountText.text = "x " + (targetAmout - InventoryManager.instance.GetItemAmount(targetItem)).ToString();

            if (InventoryManager.instance.GetItemAmount(targetItem) >= targetAmout) //player win
            {
                Debug.Log("Player Win");
                isPlayerWin = true;
            }
        }
        else //Player Lose
        {
            SceneManager.LoadScene("Mainmenu");
        }
        
    }
}
