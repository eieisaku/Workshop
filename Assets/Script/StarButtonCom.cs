using UnityEngine;
using UnityEngine.SceneManagement;

public class StarButtonCom : MonoBehaviour
{
    public void OnpressStartButton()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
