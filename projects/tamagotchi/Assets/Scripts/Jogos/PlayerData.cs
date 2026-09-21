using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    public Color playerColor;
    public Sprite backgroundImage;

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}