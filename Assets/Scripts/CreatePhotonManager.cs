using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CreatePhotonManager : MonoBehaviour
{
    public GameObject photonManagerPrefab;
    private void Awake ()
    {
        if (!FindObjectOfType<PHOTONConnect>())
        {
            Instantiate(photonManagerPrefab).GetPhotonView().ViewID = 1;
        }
    }
}