using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    Renderer rend;
    UnityEngine.UI.Image img;

    public string actionName;

    public Transform playerTarget;
    public Transform cameraTarget;
    private RoomMover roomMover;

    void Start()
    {
        rend = GetComponent<Renderer>();
        img = GetComponent<UnityEngine.UI.Image>();

        roomMover = FindObjectOfType<RoomMover>();
    }

    public void Highlight(bool on)
    {
        if (rend != null)
            rend.material.color = on ? Color.yellow : Color.white;

        if (img != null)
            img.color = on ? Color.yellow : Color.white;
    }

    public void ExecuteAction()
    {
        Debug.Log("Action: " + actionName);

        RoomManager rm = FindObjectOfType<RoomManager>();

        if (playerTarget != null && cameraTarget != null && roomMover != null)
        {
            roomMover.MoveToRoom(playerTarget, cameraTarget);
        }

        if (rm != null)
        {
            rm.ExecuteAction(actionName);
        }
    }
}