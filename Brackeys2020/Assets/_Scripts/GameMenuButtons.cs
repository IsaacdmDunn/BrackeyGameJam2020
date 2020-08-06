using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuButtons : MonoBehaviour
{
    public GameObject WinMenu;
    public Text ScoreTxt;
    public Text ScoreRecordTxt;
    public Text LevelTxt;
    public LevelData level;
    string levelID;

    public void ResetLevel()
    {
        levelID = level.levelID.ToString();
        SceneManager.LoadScene("Level" + levelID);
    }

    public void NextLevel()
    {
        levelID = (level.levelID + 1).ToString();
        SceneManager.LoadScene("Level" + levelID);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
