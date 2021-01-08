using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToFirstScene : MonoBehaviour
{
    public static bool scene = false;

    void Start()
    {
        if (!scene)
        {
            SceneManager.LoadScene(0);
        }
    }
}
