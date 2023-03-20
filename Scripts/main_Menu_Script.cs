using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_Menu_Script : MonoBehaviour
{
    //Go Methods 
    public void go_to_Settings()
    {
        //SceneManager.LoadScene("Settings");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void go_to_Audio()
    {
        SceneManager.LoadScene("Audio");
    }
    public void go_to_Gameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void go_to_Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void go_to_Graphic()
    {
        SceneManager.LoadScene("Graphics");
    }
    public void go_to_Character_Info()
    {
        SceneManager.LoadScene("CharacterPage");
    }

    //Return Methods
    public void return_to_Main_Menu()
    {
        SceneManager.LoadScene("MainMenu");
        
    }
    public void return_to_Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
