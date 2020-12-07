using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHOTONConnect : MonoBehaviour
{
    string game_version = "0.01";
    void Start()
    {
        Connect_to_Photon();
    }

    void Connect_to_Photon()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.GameVersion = game_version;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 20), PhotonNetwork.NetworkClientState.ToString());
    }
}
