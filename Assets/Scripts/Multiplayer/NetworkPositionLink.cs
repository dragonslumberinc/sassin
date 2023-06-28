using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPositionLink : MonoBehaviour
{
    private GameObject networkPlayer;
    private NetworkPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        networkPlayer = NetworkPlayer.player;
        player = networkPlayer.GetComponent<NetworkPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        player.UpdatePositionRotation(this.transform, this.transform.rotation);
    }
}
