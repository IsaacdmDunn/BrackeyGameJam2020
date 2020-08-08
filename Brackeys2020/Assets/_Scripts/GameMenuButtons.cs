using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuButtons : MonoBehaviour
{
    public GameObject WinMenu;
    public Text ScoreTxt;
    public Text TimeTxt;
    public Text LevelTxt;
    public LevelData level;
    string levelID;

    public AudioSource click;

    public void ResetLevel()
    {
        levelID = level.levelID.ToString();
        SceneManager.LoadScene("Level" + levelID);
    }

    public void NextLevel()
    {
        click.Play();
        levelID = (level.levelID + 1).ToString();
        SceneManager.LoadScene("Level" + levelID);
    }

    public void MainMenu()
    {
        click.Play();
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        click.Play();
        Application.Quit();
    }

    void FixedUpdate()
    {
        ScoreTxt.text = "Time: " + level.time.ToString();
        


        

    }
}
