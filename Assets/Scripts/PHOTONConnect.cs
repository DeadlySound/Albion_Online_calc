using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PHOTONConnect : MonoBehaviourPunCallbacks
{
    string game_version = "0.01";
    private void Awake()
    {
        GoToFirstScene.scene = true;
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
        if (room_name.Length >= 1 && PhotonNetwork.NetworkClientState == ClientState.ConnectedToMasterServer)
        {

            PhotonNetwork.CreateRoom(room_name, new Photon.Realtime.RoomOptions { MaxPlayers = 3 }, null);
            PhotonNetwork.LoadLevel(level);
        }
    }
    static public void Click_join_room(string room_name, int level)
    {
        if (room_name.Length >= 1 && PhotonNetwork.NetworkClientState == ClientState.ConnectedToMasterServer)
        {
            PhotonNetwork.JoinRoom(room_name, null);
            PhotonNetwork.LoadLevel(level);
        }
    }

    public override void OnPlayerEnteredRoom(Photon.Realtime.Player player)
    {
        ListPlayer();
    }
    public override void OnJoinedRoom()
    {
        ListPlayer();
    }
    public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer)
    {
        ListPlayer();
    }
    public void ListPlayer()
    {
        List<string> lista = new List<string>();
        foreach (var item in PhotonNetwork.PlayerList)
        {
            lista.Add(item.NickName);
        }
        Lobby.PlayerUpdateList(lista);
    }
}
