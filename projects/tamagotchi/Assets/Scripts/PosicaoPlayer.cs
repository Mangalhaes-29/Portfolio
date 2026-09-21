using Unity.Netcode;
using UnityEngine;

public class PlayerPosition : NetworkBehaviour
{
    public override void OnNetworkSpawn()
    {
        int playerCount = NetworkManager.Singleton.ConnectedClientsList.Count;

        if (playerCount == 1)
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
        else if (playerCount == 2)
        {
            if (OwnerClientId == 0)
            {
                transform.position = new Vector3(-3f, 0f, 0f);
            }
            else
            {
                transform.position = new Vector3(3f, 0f, 0f);
            }
        }
    }
}