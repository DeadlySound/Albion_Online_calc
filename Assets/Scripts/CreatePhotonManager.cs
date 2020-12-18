using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePhotonManager : MonoBehaviour
{
    public GameObject photonManagerPrefab;
    private void Awake ()
    {
        if (!FindObjectOfType<PHOTONConnect>())
        {
            Instantiate(photonManagerPrefab);
        }
    }
}