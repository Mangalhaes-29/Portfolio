using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    public Renderer rend;

    void Start()
    {
        Color playerColor = PlayerData.Instance.playerColor;
        rend.material.color = playerColor;
    }
}