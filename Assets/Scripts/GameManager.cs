using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Start()
    {
        instance = this;
    }

    [PunRPC]
    private void StartGame()
    {
        Lobby.HideLobbyScreen();
    }
}
