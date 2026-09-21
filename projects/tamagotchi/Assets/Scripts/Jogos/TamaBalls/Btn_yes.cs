using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_yes : MonoBehaviour
{
    public void ConfirmExit()
    {
        SceneManager.LoadScene("GameMenuScene");
    }
}