using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject AmmoBox;
    public GameObject PathTwoAll;
    public GameObject PathTwo;
    public GameObject WaveTwo;
    private int StageLevel = 0;// this is set up so not all check of enemies are done at the start before they are created


    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("EnemyWaveOne").Length == 0 && StageLevel == 1)
        {
            AmmoBox.SetActive(true);
            StageLevel = 2;
        }
        if (GameObject.FindGameObjectsWithTag("Ammo").Length == 0 && StageLevel == 2)
        {
            PathTwoAll.SetActive(true);
            PathTwo.SetActive(true);
            WaveTwo.SetActive(true);
        }
    }

    public void QuitGame()
    {
        Application.Quit();//Quits the game
    }
    public void LevelUpStage()
    {
        StageLevel = 1;
    }
}
