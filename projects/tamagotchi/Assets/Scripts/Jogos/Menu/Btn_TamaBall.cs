using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_TamaBall : MonoBehaviour
{
    public void PlayTamaBall()
    {
        SceneManager.LoadScene("Game_TamaBall");
    }
}