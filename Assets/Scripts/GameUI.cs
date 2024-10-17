using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public TextMeshProUGUI HighScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.SetText(GameManager.instance.GetScore().ToString());
        HighScore.SetText(GameManager.instance.GetScore().ToString());
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
