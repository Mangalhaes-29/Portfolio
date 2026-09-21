using Unity.Netcode;
using UnityEngine;

public class PlayerRoom : NetworkBehaviour
{
    [ServerRpc]
    public void MovePlayerServerRpc(Vector3 newPosition)
    {
        if (OwnerClientId == 0)
        {
            transform.position =
                newPosition + new Vector3(-25f, 0f, 0f);
        }
        else
        {
            transform.position =
                newPosition + new Vector3(25f, 0f, 0f);
        }
    }
}