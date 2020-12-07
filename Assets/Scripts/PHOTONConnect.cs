using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHOTONConnect : MonoBehaviour
{
    string game_version = "0.01";
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
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
    static public void Click_create_room(string room_name, int level)
    {
        if (room_name.Length >= 1)
        {
            PhotonNetwork.CreateRoom(room_name, new Photon.Realtime.RoomOptions { MaxPlayers = 5 }, null);
            PhotonNetwork.LoadLevel(level);
        }
    }
    static public void Click_join_room(string room_name, int level)
    {
        if (room_name.Length >= 1)
        {
            PhotonNetwork.JoinRoom(room_name, null);
            PhotonNetwork.LoadLevel(level);
        }
    }
}
