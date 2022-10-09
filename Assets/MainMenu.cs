using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
       Debug.Log("Play Game!");
    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    List<int> widths = new List<int>() {480,560,576};
    List<int> heights = new List<int>() {640,960,720};

    public void SetScreenSize (int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);  
    }

    public void SetFullscreen (bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }

    
}
