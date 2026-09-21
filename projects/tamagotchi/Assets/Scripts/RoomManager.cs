using UnityEngine;
using UnityEngine.SceneManagement;


public class RoomManager : MonoBehaviour
{
    public NeedsSystem needsSystem;

    public GameObject quarto;
    public GameObject sala;
    public GameObject cozinha;
    public GameObject casaDeBanho;

    public SelectionManager selectionManager;

    public SelectableObject[] quartoObjects;
    public SelectableObject[] salaObjects;
    public SelectableObject[] cozinhaObjects;
    public SelectableObject[] casaBanhoObjects;

    public SelectableObject[] menuObjects;
    public GameObject roomMenuUI;

    public void BackToMenu()
    {
        quarto.SetActive(false);
        sala.SetActive(false);
        cozinha.SetActive(false);
        casaDeBanho.SetActive(false);

        roomMenuUI.SetActive(true);

        selectionManager.SetObjects(menuObjects);
        selectionManager.inRoom = false;
    }

    public void ExecuteAction(string action)
    {
        if (action == "Quarto")
            ActivateRoom(quarto, quartoObjects);

        else if (action == "Sala")
            ActivateRoom(sala, salaObjects);

        else if (action == "Cozinha")
            ActivateRoom(cozinha, cozinhaObjects);

        else if (action == "CasaBanho")
            ActivateRoom(casaDeBanho, casaBanhoObjects);

        else if (action == "Dormir")
        {
            Debug.Log("CLIQUE DORMIR");
            needsSystem.sleep += 40f;
        }

        else if (action == "Diário")
        {
            FindObjectOfType<DiarySystem>().OpenDiary();
        }

        else if (action == "Jogos")
        {
            SceneManager.LoadScene("GameMenuScene");
        }

        else if (action == "Comer")
            needsSystem.hunger += 40f;

        else if (action == "Banho")
            needsSystem.bath += 50f;

        else if (action == "Escovar")
            needsSystem.teeth += 30f;
    }

    void ActivateRoom(GameObject room, SelectableObject[] objects)
    {
        quarto.SetActive(false);
        sala.SetActive(false);
        cozinha.SetActive(false);
        casaDeBanho.SetActive(false);

        roomMenuUI.SetActive(false);

        room.SetActive(true);

        selectionManager.SetObjects(objects);
        selectionManager.inRoom = true;
    }
}