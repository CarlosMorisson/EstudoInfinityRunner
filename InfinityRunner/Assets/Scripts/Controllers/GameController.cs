using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : UIManagement
{
    public static GameController instance;
    [SerializeField] private Button StartButton;
    [SerializeField] private GameObject[] UIGame;
    void Start()
    {
        Time.timeScale *= 0;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        for (int i = 0; UIGame.Length > i; i++)
        {
            UIGame[i].SetActive(true);
        }
        Time.timeScale += 1;
        Destroy(StartButton.gameObject);
        
    }
    public void GameOver()
    {
        GameOverLabel.SetActive(true);
        Time.timeScale *= 0;
        for (int i = 0; UIGame.Length > i; i++)
        {
            UIGame[i].SetActive(false);
        }
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
