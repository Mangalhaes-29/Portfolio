using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)

            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

    }

    public void SaveGame(int score)
    {
        // Logica para salvar num txt
    }


    public void LoadGame(string fileName)
    {
        // Logica para salvar num txt
    }
}
