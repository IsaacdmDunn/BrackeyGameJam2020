using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SelectLevel(int levelID)
    {
        SceneManager.LoadScene("Level" + levelID.ToString());
    }
    
    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/Isaac_dm_Dunn");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {

    }
}
