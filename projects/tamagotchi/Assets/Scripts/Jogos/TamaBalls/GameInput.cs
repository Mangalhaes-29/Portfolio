using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance;

    public float horizontal;

    public GameObject ExitMenu;

    public GameObject scoreMenu;

    void Awake()
    {
        Instance = this;
    }

    public void PressLeft()
    {
        Debug.Log("LEFT");
        horizontal = -1;
    }

    public void PressRight()
    {
        Debug.Log("RIGHT");
        horizontal = 1;
    }

    public void Release()
    {
        Debug.Log("RELEASE");
        horizontal = 0;
    }

    public void PressUp()
    {
        scoreMenu.SetActive(true);
    }

    public void ReleaseUp()
    {
        scoreMenu.SetActive(false);
    }

    public void PressDown()
    {
        ExitMenu.SetActive(true);
        Time.timeScale = 0f;
    }


}
