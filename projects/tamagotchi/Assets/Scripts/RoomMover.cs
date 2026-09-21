using UnityEngine;
using Unity.Netcode;

public class RoomMover : MonoBehaviour
{
    private Transform player;

    public Transform cameraTransform;

    public Vector3 cameraOffset = new Vector3(0, 3, -5);

    void Update()
    {
        if (player == null)
        {
            if (NetworkManager.Singleton != null &&
                NetworkManager.Singleton.LocalClient != null &&
                NetworkManager.Singleton.LocalClient.PlayerObject != null)
            {
                player =
                    NetworkManager.Singleton.LocalClient.PlayerObject.transform;
            }
        }
    }

    public void MoveToRoom(Transform playerTarget,Transform cameraTarget)
    {
        if (player == null)
            return;

        player.GetComponent<PlayerRoom>()
            .MovePlayerServerRpc(playerTarget.position);

        cameraTransform.position = cameraTarget.position;
    }   
}