using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Lobby : MonoBehaviour
{
    public Text[] pom = new Text[0];
    public static Text[] playerT = new Text[3];
    public static GameObject lobby;
    //public GameManager manager; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && SceneManager.GetActiveScene().ToString() != "SampleScene")
        {
            foreach (var item in PhotonNetwork.PlayerList)
            {
                print(item);
            }
        }
    }
    private void Start()
    {
        for (int i = 0; i < pom.Length; i++)
        {
            playerT[i] = pom[i];
        }
        lobby = GameObject.Find("Lobby");
    }

    public static void PlayerUpdateList(List<string> playerList)
    {
        int i = 0;
        foreach (var item in playerList)
        {
            playerT[i].text = item;
            i++;
        }
        int afterIteration = i + 1;
        if (afterIteration < playerT.Length)
        {
            playerT[i].text = $"Player {afterIteration}";
        }
    }

    public void StartButton()
    {
        GameManager.instance.GetComponent<PhotonView>().RPC("StartGame", RpcTarget.AllBuffered);
    }

    public static void HideLobbyScreen()
    {
        lobby.SetActive(false);
    }
}
