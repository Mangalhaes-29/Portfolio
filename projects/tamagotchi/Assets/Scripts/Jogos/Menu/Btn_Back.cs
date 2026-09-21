using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_Back : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("MainHouse");
    }
}
