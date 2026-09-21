using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public SelectableObject[] objects;

    private int currentIndex = 0;

    public bool inRoom = false;

    public RoomManager roomManager;


    void Start()
    {
        UpdateSelection();
    }


    public void MoveRight()
    {
        currentIndex++;

        if (currentIndex >= objects.Length)
            currentIndex = 0;

        UpdateSelection();
    }


    public void MoveLeft()
    {
        currentIndex--;

        if (currentIndex < 0)
            currentIndex = objects.Length - 1;

        UpdateSelection();
    }


    public void MoveDown()
    {
        if (inRoom && currentIndex == 0)
        {
            roomManager.BackToMenu();
            return;
        }

        MoveRight();
    }


    public void Confirm()
    {
        objects[currentIndex].ExecuteAction();
    }


    void UpdateSelection()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].Highlight(i == currentIndex);
        }
    }


    public void SetObjects(SelectableObject[] newObjects)
    {
        objects = newObjects;
        currentIndex = 0;
        UpdateSelection();
    }
}
