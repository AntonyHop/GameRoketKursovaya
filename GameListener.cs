using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameListener : MonoBehaviour
{
    public int lifestart = 100;

    Text score;
    Text life;
    int inScore = 0;
    void Start()
    {
        GameObject scoreObj = GameObject.FindGameObjectWithTag("Score");
        score = scoreObj.GetComponent<Text>();
        GameObject lifeObj = GameObject.FindGameObjectWithTag("Life");
        life = lifeObj.GetComponent<Text>();
    }

    void AddScore()
    {
        inScore++;
        score.text = inScore + "";
    }

    void Damage ()
    {
        lifestart -= 2;
        life.text = lifestart + "";
        if(lifestart < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
