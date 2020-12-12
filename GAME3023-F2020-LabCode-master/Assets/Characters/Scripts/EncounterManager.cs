using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EncounterManager : MonoBehaviour
{
    public void EnterEncounter()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void ExitEncounter()
    {
        // In a full game, your code should remember the player's last area and return there
        SceneManager.LoadScene("Overworld");
    }
}
