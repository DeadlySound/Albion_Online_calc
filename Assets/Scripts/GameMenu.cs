using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public static bool gameIsPaused = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOrResume(!gameIsPaused);
        }
    }
    public void PauseOrResume(bool isActive)
    {
        pauseMenuUI.SetActive(isActive);
        gameIsPaused = isActive;
    }

    public void Load_Main_Menu()
    {
        // TODO ta metoda sprawia, że dubluje się obiekt PhotonManager
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel(0);
    }
}
