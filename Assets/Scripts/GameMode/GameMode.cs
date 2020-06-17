using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    //set up
    public int teamAmmount = 2;

    public Text blueScrTex;
    public Text redScrTex;

    public List<Team> teams;
    public List<Transform> spawnPoints;

    protected void Start()
    {
        Debug.Log("Setting up game");
        SetUpGame();
    }

    private void Update()
    {
        blueScrTex.text = "Score: " + teams[0].score;
        redScrTex.text = "Score: " + teams[1].score;
    }

    public void SetUpGame()
    {
        for(int teamID = 0; teamID < teamAmmount; teamID++)
        {
            teams.Add(new Team());
        }
    }

    public void AddScore(int teamID, int score)
    {
        teams[teamID].score += score;
    }
}

[System.Serializable]
public class Team
{
    public int score;
}