using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_no : MonoBehaviour
{
    public GameObject ExitMenu;

    public void CancelExit()
    {
        ExitMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}