using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Player : MonoBehaviour
{
    private LayerMask mask;
    
    private void Start()
    {
        mask = LayerMask.GetMask("Interactable");
    }
    void Update()
    {
        
        Debug.DrawRay(Camera.main.transform.position,
                                Camera.main.transform.forward * 5f, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.transform.position,
                                Camera.main.transform.forward,
                                out RaycastHit hit,
                                5f, mask))
            {
                Debug.Log("Hit");
                IInteractable comp =hit.collider.gameObject.GetComponent<IInteractable>();
                comp.Interact();
            }
        }
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            GameManager.instance.OpeninventoryPanel();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GameManager.instance.CloseinventoryPanel();
        }
    }
}
