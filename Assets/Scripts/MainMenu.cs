using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public InputField room_name_input;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// / voidy do funkcji obsługujących guziki
    public void On_click_create_room()
    {
        PHOTONConnect.Click_create_room(room_name_input.text, 1);
    }
    public void On_click_join_room()
    {
        PHOTONConnect.Click_join_room(room_name_input.text, 1);
    }
    public void ExitGame()
    {
       
        Application.Quit();
    }

}
