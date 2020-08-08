using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelData : MonoBehaviour
{
    public int levelID;
    public float time;
    public float timeRecord;
    public bool winCondition = false;

    public Text timeTXT;
    public GameMenuButtons gameMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (winCondition == false)
        {
            time -= Time.deltaTime;
            timeTXT.text = "Time Left: " + Mathf.Round(time).ToString();

            if (time < 0)
            {
                gameMenu.ResetLevel();
            }
        }
    }
}
